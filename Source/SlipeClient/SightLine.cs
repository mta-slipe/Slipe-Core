using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using Slipe.Shared;
using System.Numerics;
using Slipe.Client.Dx;
using Slipe.Shared.Interfaces;

namespace Slipe.Client
{
    /// <summary>
    /// Represents a line that can do raytracing operations
    /// </summary>
    public class SightLine : Dx3DLine
    {
        /// <summary>
        /// Allow the line of sight to be blocked by GTA's internally placed buildings, i.e. the world map.
        /// </summary>
        public bool CheckBuildings { get; set; }

        /// <summary>
        /// Allow the line of sight to be blocked by vehicles.
        /// </summary>
        public bool CheckVehicles { get; set; }

        /// <summary>
        /// Allow the line of sight to be blocked by peds, i.e. players.
        /// </summary>
        public bool CheckPeds { get; set; }

        /// <summary>
        /// Allow the line of sight to be blocked by WorldObjects.
        /// </summary>
        public bool CheckWorldObjects { get; set; }

        /// <summary>
        /// Allow the line of sight to be blocked by translucent game objects, e.g. glass.
        /// </summary>
        public bool SeeThroughStuff { get; set; }

        /// <summary>
        /// Allow the line of sight to pass through objects that have (K) property enabled in "object.dat" data file. (i.e. Most dynamic objects like boxes or barrels)
        /// </summary>
        public bool IgnoreSomeObjectsForCamera { get; set; }

        /// <summary>
        ///  Allow the line of sight to be blocked by things that can be shot through. (Not used in IsClear!)
        /// </summary>
        public bool ShootThroughStuff { get; set; }

        /// <summary>
        /// Include the results of hitting a world model.
        /// </summary>
        public bool IncludeWorldModelInformation { get; set; }

        /// <summary>
        /// Includes car tyre hits.
        /// </summary>
        public bool IncludeCarTyreHits { get; set; }

        /// <summary>
        /// Allow the line of sight to pass through a certain specified element.
        /// </summary>
        public PhysicalElement IgnoredElement { get; set; }

        /// <summary>
        /// Creates a SightLine from a start and an end position
        /// </summary>
        public SightLine(Vector3 startPos, Vector3 endPos, bool checkBuildings = true, bool checkVehicles = true, bool checkPeds = true, bool checkWorldObjects = true, bool seeThroughStuff = false, bool ignoreSomeObjectsForCamera = false, bool shootThroughStuff = false, bool includeWorldModelInformation = false, bool includeCarTyreHits = true, PhysicalElement ignoredElement = null) : base(startPos, endPos)
        {
            CheckBuildings = checkBuildings;
            CheckVehicles = checkVehicles;
            CheckPeds = checkPeds;
            CheckWorldObjects = checkWorldObjects;
            SeeThroughStuff = seeThroughStuff;
            IgnoreSomeObjectsForCamera = ignoreSomeObjectsForCamera;
            ShootThroughStuff = shootThroughStuff;
            IncludeWorldModelInformation = includeWorldModelInformation;
            IncludeCarTyreHits = includeCarTyreHits;
            IgnoredElement = ignoredElement;
        }

        /// <summary>
        /// Create a SightLine attached to a certain object
        /// </summary>
        public SightLine(IToAttachable attachedTo, Vector3 relativeEndPos, Matrix4x4 offset, bool checkBuildings = true, bool checkVehicles = true, bool checkPeds = true, bool checkWorldObjects = true, bool seeThroughStuff = false, bool ignoreSomeObjectsForCamera = false, bool shootThroughStuff = false, bool includeWorldModelInformation = false, bool includeCarTyreHits = true, PhysicalElement ignoredElement = null) : base(attachedTo, relativeEndPos, offset)
        {
            CheckBuildings = checkBuildings;
            CheckVehicles = checkVehicles;
            CheckPeds = checkPeds;
            CheckWorldObjects = checkWorldObjects;
            SeeThroughStuff = seeThroughStuff;
            IgnoreSomeObjectsForCamera = ignoreSomeObjectsForCamera;
            ShootThroughStuff = shootThroughStuff;
            IncludeWorldModelInformation = includeWorldModelInformation;
            IncludeCarTyreHits = includeCarTyreHits;
            IgnoredElement = ignoredElement;
        }

        /// <summary>
        /// Test if the SightLine hits water. Throws an exception when no water is hit
        /// </summary>
        public Vector3 WaterCollisionPosition
        {
            get
            {
                Tuple<bool, float, float, float> result = MTAClient.TestLineAgainstWater(StartPosition.X, StartPosition.Y, StartPosition.Z, EndPosition.X, EndPosition.Y, EndPosition.Z);
                if (!result.Item1)
                    throw new Exception("SightLine did not collide with water");

                return new Vector3(result.Item2, result.Item3, result.Item4);
            }
        }

        /// <summary>
        /// Get a SightLineData object for the current line of sight
        /// </summary>
        public SightLineData Data
        {
            get
            {
                return new SightLineData(MTAClient.ProcessLineOfSight(StartPosition.X, StartPosition.Y, StartPosition.Z, EndPosition.X, EndPosition.Y, EndPosition.Z, CheckBuildings, CheckVehicles, CheckPeds, CheckWorldObjects, false, SeeThroughStuff, IgnoreSomeObjectsForCamera, ShootThroughStuff, IgnoredElement?.MTAElement, IncludeWorldModelInformation, IncludeCarTyreHits));
            }
        }

        /// <summary>
        /// Checks if there are obstacles between two points of the game world, optionally ignoring certain kinds of elements
        /// </summary>
        public bool IsClear
        {
            get
            {
                return MTAClient.IsLineOfSightClear(StartPosition.X, StartPosition.Y, StartPosition.Z, EndPosition.X, EndPosition.Y, EndPosition.Z, CheckBuildings, CheckVehicles, CheckPeds, CheckWorldObjects, false, SeeThroughStuff, IgnoreSomeObjectsForCamera, IgnoredElement?.MTAElement);
            }
        }
    }
}
