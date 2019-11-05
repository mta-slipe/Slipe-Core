using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Shared.Vehicles;
using System.Numerics;
using Slipe.MtaDefinitions;
using System.Linq;

namespace Slipe.Client.Vehicles
{
    /// <summary>
    /// Represents a vehicle model 
    /// </summary>
    public class VehicleModel : SharedVehicleModel
    {
        #region Static Properties
        public static class Bikes
        {
            public static VehicleModel Bf400 { get { return new VehicleModel(581); } }
            public static VehicleModel Faggio { get { return new VehicleModel(462); } }
            public static VehicleModel Fcr900 { get { return new VehicleModel(521); } }
            public static VehicleModel Freeway { get { return new VehicleModel(463); } }
            public static VehicleModel Hpv1000 { get { return new VehicleModel(523); } }
            public static VehicleModel Nrg500 { get { return new VehicleModel(522); } }
            public static VehicleModel Pcj600 { get { return new VehicleModel(461); } }
            public static VehicleModel Pizzaboy { get { return new VehicleModel(448); } }
            public static VehicleModel Sanchez { get { return new VehicleModel(468); } }
            public static VehicleModel Wayfarer { get { return new VehicleModel(586); } }
            public static VehicleModel Quadbike { get { return new VehicleModel(471); } }
            public static VehicleModel Bike { get { return new VehicleModel(509); } }
            public static VehicleModel Bmx { get { return new VehicleModel(481); } }
            public static VehicleModel Mountainbike { get { return new VehicleModel(510); } }
        }

        public static class Cars
        {
            public static VehicleModel Alpha { get { return new VehicleModel(602); } }
            public static VehicleModel Banshee { get { return new VehicleModel(429); } }
            public static VehicleModel Buffalo { get { return new VehicleModel(402); } }
            public static VehicleModel Bullet { get { return new VehicleModel(541); } }
            public static VehicleModel Cheetah { get { return new VehicleModel(415); } }
            public static VehicleModel Comet { get { return new VehicleModel(480); } }
            public static VehicleModel Elegy { get { return new VehicleModel(562); } }
            public static VehicleModel Euros { get { return new VehicleModel(587); } }
            public static VehicleModel Flash { get { return new VehicleModel(565); } }
            public static VehicleModel Infernus { get { return new VehicleModel(411); } }
            public static VehicleModel Jester { get { return new VehicleModel(559); } }
            public static VehicleModel Phoenix { get { return new VehicleModel(603); } }
            public static VehicleModel Sultan { get { return new VehicleModel(560); } }
            public static VehicleModel Supergt { get { return new VehicleModel(506); } }
            public static VehicleModel Turismo { get { return new VehicleModel(451); } }
            public static VehicleModel Uranus { get { return new VehicleModel(558); } }
            public static VehicleModel Windsor { get { return new VehicleModel(555); } }
            public static VehicleModel Zr350 { get { return new VehicleModel(477); } }
            public static VehicleModel Blade { get { return new VehicleModel(536); } }
            public static VehicleModel Broadway { get { return new VehicleModel(575); } }
            public static VehicleModel Buccaneer { get { return new VehicleModel(518); } }
            public static VehicleModel Esperanto { get { return new VehicleModel(419); } }
            public static VehicleModel Remington { get { return new VehicleModel(534); } }
            public static VehicleModel Savanna { get { return new VehicleModel(567); } }
            public static VehicleModel Slamvan { get { return new VehicleModel(535); } }
            public static VehicleModel Tornado { get { return new VehicleModel(576); } }
            public static VehicleModel Voodoo { get { return new VehicleModel(412); } }
            public static VehicleModel Blistacompact { get { return new VehicleModel(496); } }
            public static VehicleModel Bravura { get { return new VehicleModel(401); } }
            public static VehicleModel Cadrona { get { return new VehicleModel(527); } }
            public static VehicleModel Clover { get { return new VehicleModel(542); } }
            public static VehicleModel Feltzer { get { return new VehicleModel(533); } }
            public static VehicleModel Fortune { get { return new VehicleModel(526); } }
            public static VehicleModel Hermes { get { return new VehicleModel(474); } }
            public static VehicleModel Hustler { get { return new VehicleModel(545); } }
            public static VehicleModel Majestic { get { return new VehicleModel(517); } }
            public static VehicleModel Manana { get { return new VehicleModel(410); } }
            public static VehicleModel Previon { get { return new VehicleModel(436); } }
            public static VehicleModel Sabre { get { return new VehicleModel(475); } }
            public static VehicleModel Stallion { get { return new VehicleModel(439); } }
            public static VehicleModel Tampa { get { return new VehicleModel(549); } }
            public static VehicleModel Virgo { get { return new VehicleModel(491); } }
            public static VehicleModel Admiral { get { return new VehicleModel(445); } }
            public static VehicleModel Elegant { get { return new VehicleModel(507); } }
            public static VehicleModel Emperor { get { return new VehicleModel(585); } }
            public static VehicleModel Glendale { get { return new VehicleModel(466); } }
            public static VehicleModel Greenwood { get { return new VehicleModel(492); } }
            public static VehicleModel Intruder { get { return new VehicleModel(546); } }
            public static VehicleModel Merit { get { return new VehicleModel(551); } }
            public static VehicleModel Nebula { get { return new VehicleModel(516); } }
            public static VehicleModel Oceanic { get { return new VehicleModel(467); } }
            public static VehicleModel Premier { get { return new VehicleModel(426); } }
            public static VehicleModel Primo { get { return new VehicleModel(547); } }
            public static VehicleModel Sentinel { get { return new VehicleModel(405); } }
            public static VehicleModel Stafford { get { return new VehicleModel(580); } }
            public static VehicleModel Stretch { get { return new VehicleModel(409); } }
            public static VehicleModel Sunrise { get { return new VehicleModel(550); } }
            public static VehicleModel Tahoma { get { return new VehicleModel(566); } }
            public static VehicleModel Vincent { get { return new VehicleModel(540); } }
            public static VehicleModel Washington { get { return new VehicleModel(421); } }
            public static VehicleModel Willard { get { return new VehicleModel(529); } }
            public static VehicleModel Ambulance { get { return new VehicleModel(416); } }
            public static VehicleModel Barracks { get { return new VehicleModel(433); } }
            public static VehicleModel Enforcer { get { return new VehicleModel(427); } }
            public static VehicleModel Fbirancher { get { return new VehicleModel(490); } }
            public static VehicleModel Fbitruck { get { return new VehicleModel(528); } }
            public static VehicleModel Firetruckladder { get { return new VehicleModel(544); } }
            public static VehicleModel Policecarls { get { return new VehicleModel(596); } }
            public static VehicleModel Policecarlv { get { return new VehicleModel(598); } }
            public static VehicleModel Policecarsf { get { return new VehicleModel(597); } }
            public static VehicleModel Policeranger { get { return new VehicleModel(599); } }
            public static VehicleModel Cementtruck { get { return new VehicleModel(524); } }
            public static VehicleModel Dft30 { get { return new VehicleModel(578); } }
            public static VehicleModel Dozer { get { return new VehicleModel(486); } }
            public static VehicleModel Dumper { get { return new VehicleModel(406); } }
            public static VehicleModel Dune { get { return new VehicleModel(573); } }
            public static VehicleModel Flatbed { get { return new VehicleModel(455); } }
            public static VehicleModel Forklift { get { return new VehicleModel(530); } }
            public static VehicleModel Linerunner { get { return new VehicleModel(403); } }
            public static VehicleModel Packer { get { return new VehicleModel(443); } }
            public static VehicleModel Roadtrain { get { return new VehicleModel(515); } }
            public static VehicleModel Sweeper { get { return new VehicleModel(574); } }
            public static VehicleModel Tanker { get { return new VehicleModel(514); } }
            public static VehicleModel Towtruck { get { return new VehicleModel(525); } }
            public static VehicleModel Trashmaster { get { return new VehicleModel(408); } }
            public static VehicleModel Utilityvan { get { return new VehicleModel(552); } }
            public static VehicleModel Benson { get { return new VehicleModel(499); } }
            public static VehicleModel Blackboxville { get { return new VehicleModel(609); } }
            public static VehicleModel Bobcat { get { return new VehicleModel(422); } }
            public static VehicleModel Boxville { get { return new VehicleModel(498); } }
            public static VehicleModel Mule { get { return new VehicleModel(414); } }
            public static VehicleModel Picador { get { return new VehicleModel(600); } }
            public static VehicleModel Sadler { get { return new VehicleModel(543); } }
            public static VehicleModel Securicar { get { return new VehicleModel(428); } }
            public static VehicleModel Walton { get { return new VehicleModel(478); } }
            public static VehicleModel Yankee { get { return new VehicleModel(456); } }
            public static VehicleModel Yosemite { get { return new VehicleModel(554); } }
            public static VehicleModel Berkleysrcvan { get { return new VehicleModel(459); } }
            public static VehicleModel Burrito { get { return new VehicleModel(482); } }
            public static VehicleModel Camper { get { return new VehicleModel(483); } }
            public static VehicleModel Journey { get { return new VehicleModel(508); } }
            public static VehicleModel Moonbeam { get { return new VehicleModel(418); } }
            public static VehicleModel Newsvan { get { return new VehicleModel(582); } }
            public static VehicleModel Pony { get { return new VehicleModel(413); } }
            public static VehicleModel Rumpo { get { return new VehicleModel(440); } }
            public static VehicleModel Baggage { get { return new VehicleModel(485); } }
            public static VehicleModel Bandito { get { return new VehicleModel(568); } }
            public static VehicleModel Bfinjection { get { return new VehicleModel(424); } }
            public static VehicleModel Bloodringbanger { get { return new VehicleModel(504); } }
            public static VehicleModel Bus { get { return new VehicleModel(431); } }
            public static VehicleModel Caddy { get { return new VehicleModel(457); } }
            public static VehicleModel Coach { get { return new VehicleModel(437); } }
            public static VehicleModel Combineharvester { get { return new VehicleModel(532); } }
            public static VehicleModel Hotdog { get { return new VehicleModel(588); } }
            public static VehicleModel Hotknife { get { return new VehicleModel(434); } }
            public static VehicleModel Hotringracer1 { get { return new VehicleModel(494); } }
            public static VehicleModel Hotringracer2 { get { return new VehicleModel(502); } }
            public static VehicleModel Hotringracer3 { get { return new VehicleModel(503); } }
            public static VehicleModel Monster1 { get { return new VehicleModel(444); } }
            public static VehicleModel Monster2 { get { return new VehicleModel(556); } }
            public static VehicleModel Monster3 { get { return new VehicleModel(557); } }
            public static VehicleModel Mower { get { return new VehicleModel(572); } }
            public static VehicleModel Mrwhoopee { get { return new VehicleModel(423); } }
            public static VehicleModel Kart { get { return new VehicleModel(571); } }
            public static VehicleModel Tractor { get { return new VehicleModel(531); } }
            public static VehicleModel Tug { get { return new VehicleModel(583); } }
            public static VehicleModel Vortex { get { return new VehicleModel(539); } }
            public static VehicleModel RcBandit { get { return new VehicleModel(441); } }
            public static VehicleModel RcFlowerpot { get { return new VehicleModel(594); } }
            public static VehicleModel RcTiger { get { return new VehicleModel(564); } }
            public static VehicleModel Club { get { return new VehicleModel(589); } }
            public static VehicleModel Huntley { get { return new VehicleModel(579); } }
            public static VehicleModel Landstalker { get { return new VehicleModel(400); } }
            public static VehicleModel Mesa { get { return new VehicleModel(500); } }
            public static VehicleModel Patriot { get { return new VehicleModel(470); } }
            public static VehicleModel Perennial { get { return new VehicleModel(404); } }
            public static VehicleModel Rancher { get { return new VehicleModel(489); } }
            public static VehicleModel Regina { get { return new VehicleModel(479); } }
            public static VehicleModel Romero { get { return new VehicleModel(442); } }
            public static VehicleModel Sandking { get { return new VehicleModel(495); } }
            public static VehicleModel Solair { get { return new VehicleModel(458); } }
            public static VehicleModel Stratum { get { return new VehicleModel(561); } }
        }

        public static class Boats
        {
            public static BoatModel Coastguard { get { return new BoatModel(472); } }
            public static BoatModel Dinghy { get { return new BoatModel(473); } }
            public static BoatModel Jetmax { get { return new BoatModel(493); } }
            public static BoatModel Launch { get { return new BoatModel(595); } }
            public static BoatModel Marquis { get { return new BoatModel(484); } }
            public static BoatModel Predator { get { return new BoatModel(430); } }
            public static BoatModel Reefer { get { return new BoatModel(453); } }
            public static BoatModel Speeder { get { return new BoatModel(452); } }
            public static BoatModel Squalo { get { return new BoatModel(446); } }
            public static BoatModel Tropic { get { return new BoatModel(454); } }
        }

        public static class Planes
        {
            public static PlaneModel Andromada { get { return new PlaneModel(592); } }
            public static PlaneModel At400 { get { return new PlaneModel(577); } }
            public static PlaneModel Beagle { get { return new PlaneModel(511); } }
            public static PlaneModel Cropduster { get { return new PlaneModel(512); } }
            public static PlaneModel Dodo { get { return new PlaneModel(593); } }
            public static PlaneModel Hydra { get { return new PlaneModel(520); } }
            public static PlaneModel Nevada { get { return new PlaneModel(553); } }
            public static PlaneModel Rustler { get { return new PlaneModel(476); } }
            public static PlaneModel Shamal { get { return new PlaneModel(519); } }
            public static PlaneModel Skimmer { get { return new PlaneModel(460); } }
            public static PlaneModel Stuntplane { get { return new PlaneModel(513); } }
            public static PlaneModel RcBaron { get { return new PlaneModel(464); } }
        }

        public static class Helicopters
        {
            public static HelicopterModel Cargobob { get { return new HelicopterModel(548); } }
            public static HelicopterModel Hunter { get { return new HelicopterModel(425); } }
            public static HelicopterModel Leviathan { get { return new HelicopterModel(417); } }
            public static HelicopterModel Maverick { get { return new HelicopterModel(487); } }
            public static HelicopterModel Newschopper { get { return new HelicopterModel(488); } }
            public static HelicopterModel PoliceMaverick { get { return new HelicopterModel(497); } }
            public static HelicopterModel Raindance { get { return new HelicopterModel(563); } }
            public static HelicopterModel Seasparrow { get { return new HelicopterModel(447); } }
            public static HelicopterModel Sparrow { get { return new HelicopterModel(469); } }
            public static HelicopterModel RcGoblin { get { return new HelicopterModel(501); } }
            public static HelicopterModel RcRaider { get { return new HelicopterModel(465); } }
        }

        public static class Trailers
        {
            public static TrailerModel BaggageCovered { get { return new TrailerModel(606); } }
            public static TrailerModel BaggageUncovered { get { return new TrailerModel(607); } }
            public static TrailerModel Steps { get { return new TrailerModel(608); } }
            public static TrailerModel Farmtrailer { get { return new TrailerModel(610); } }
            public static TrailerModel Streetcleaner { get { return new TrailerModel(611); } }
            public static TrailerModel GasSemi { get { return new TrailerModel(584); } }
            public static TrailerModel Semi { get { return new TrailerModel(435); } }
            public static TrailerModel OpenSemi { get { return new TrailerModel(450); } }
            public static TrailerModel SmallSemi { get { return new TrailerModel(591); } }
        }

        public static class Trains
        {
            public static TrainModel FreightEngine { get { return new TrainModel(537); } }
            public static TrainModel BoxFreight { get { return new TrainModel(590); } }
            public static TrainModel FlatFreight { get { return new TrainModel(569); } }
            public static TrainModel BrownStreakEngine { get { return new TrainModel(538); } }
            public static TrainModel BrownStreakCarriage { get { return new TrainModel(570); } }
            public static TrainModel Trolly { get { return new TrainModel(449); } }
        }

        public static class TurretedVehicles
        {
            public static TurretedModel Rhino { get { return new TurretedModel(432); } }
            public static TurretedModel Swat { get { return new TurretedModel(601); } }
            public static TurretedModel Firetruck { get { return new TurretedModel(407); } }
        }

        public static class Taxis
        {
            public static TaxiModel Cabbie { get { return new TaxiModel(438); } }
            public static TaxiModel Taxi { get { return new TaxiModel(420); } }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get the Primary front lights as a dummy
        /// </summary>
        public VehicleModelDummy PrimaryFrontLights
        {
            get
            {
                return new VehicleModelDummy(this, "light_front_main");
            }
        }

        /// <summary>
        /// Get the Primary rear lights as a dummy
        /// </summary>
        public VehicleModelDummy PrimaryRearLights
        {
            get
            {
                return new VehicleModelDummy(this, "light_rear_main");
            }
        }

        /// <summary>
        /// Get the Secondary front lights as a dummy
        /// </summary>
        public VehicleModelDummy SecondaryFrontLights
        {
            get
            {
                return new VehicleModelDummy(this, "light_front_second");
            }
        }

        /// <summary>
        /// Get the Secondary rear lights as a dummy
        /// </summary>
        public VehicleModelDummy SecondaryRearLights
        {
            get
            {
                return new VehicleModelDummy(this, "light_rear_second");
            }
        }

        /// <summary>
        /// Get the front seat as a dummy
        /// </summary>
        public VehicleModelDummy FrontSeat
        {
            get
            {
                return new VehicleModelDummy(this, "seat_front");
            }
        }

        /// <summary>
        /// Get the rear seat as a dummy
        /// </summary>
        public VehicleModelDummy RearSeat
        {
            get
            {
                return new VehicleModelDummy(this, "seat_rear");
            }
        }

        /// <summary>
        /// Get the exhaust as a dummy
        /// </summary>
        public VehicleModelDummy Exhaust
        {
            get
            {
                return new VehicleModelDummy(this, "exhaust");
            }
        }

        /// <summary>
        /// Get the engine as a dummy
        /// </summary>
        public VehicleModelDummy Engine
        {
            get
            {
                return new VehicleModelDummy(this, "engine");
            }
        }

        /// <summary>
        /// Get the gas cap as a dummy
        /// </summary>
        public VehicleModelDummy GasCap
        {
            get
            {
                return new VehicleModelDummy(this, "gas_cap");
            }
        }

        /// <summary>
        /// Get the trailer hook as a dummy
        /// </summary>
        public VehicleModelDummy TrailerHook
        {
            get
            {
                return new VehicleModelDummy(this, "trailer_attach");
            }
        }

        /// <summary>
        /// Get the hand rest as a dummy
        /// </summary>
        public VehicleModelDummy HandRest
        {
            get
            {
                return new VehicleModelDummy(this, "hand_rest");
            }
        }

        /// <summary>
        /// Get the secondary exhaust as a dummy
        /// </summary>
        public VehicleModelDummy SecondaryExhaust
        {
            get
            {
                return new VehicleModelDummy(this, "exhaust_second");
            }
        }

        /// <summary>
        /// Get the air trail as a dummy
        /// </summary>
        public VehicleModelDummy AirTrail
        {
            get
            {
                return new VehicleModelDummy(this, "wing_airtrail");
            }
        }

        /// <summary>
        /// Get the vehicle gun as a dummy
        /// </summary>
        public VehicleModelDummy VehicleGun
        {
            get
            {
                return new VehicleModelDummy(this, "veh_gun");
            }
        }

        #endregion

        protected VehicleModel(int id) : base(id) { }

        #region Static Methods
        /// <summary>
        /// Get a vehicle model from the model name as a string, instantiated as the right model class
        /// </summary>
        /// <param name="name">The Mta name of the vehicle</param>
        /// <returns>The Vehicle model, instantiated as the right model class</returns>
        public static VehicleModel FromName(string name)
        {
            return FromId(MtaShared.GetVehicleModelFromName(name));
        }

        /// <summary>
        /// Get a vehicle model from its ID, instantiated as the right model class
        /// </summary>
        /// <param name="id">The Mta ID of the vehicle</param>
        /// <returns>The Vehicle model, instantiated as the right model class</returns>
        public static VehicleModel FromId(int id)
        {
            if (boatModels.Contains(id))
                return new BoatModel(id);
            if (planeModels.Contains(id))
                return new PlaneModel(id);
            if (helicopterModels.Contains(id))
                return new HelicopterModel(id);
            if (trailerModels.Contains(id))
                return new TrailerModel(id);
            if (trainModels.Contains(id))
                return new TrainModel(id);
            if (turretedModels.Contains(id))
                return new TurretedModel(id);
            if (taxiModels.Contains(id))
                return new TaxiModel(id);

            return new VehicleModel(id);
        }
        #endregion
    }
}
