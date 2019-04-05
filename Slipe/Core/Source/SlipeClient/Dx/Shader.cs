using System;
using System.Collections.Generic;
using System.Text;
using Slipe.Client.Enums;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared.Elements;

namespace Slipe.Client.Dx
{
    /// <summary>
    /// A shader is a graphical 
    /// </summary>
    public class Shader : Material
    {
        /// <summary>
        /// The name of the technique that will be used.
        /// </summary>
        public string TechniqueName { get; }

        /// <summary>
        /// Create a shader from file or raw data
        /// </summary>
        public Shader(string filePathOrRaw, float priority = 0, float maxDistance = 0, bool layered = false, ShaderElementType shaderElementType = ShaderElementType.All)
        {
            Tuple<MTAElement, string> result = MTAClient.DxCreateShader(filePathOrRaw, priority, maxDistance, layered, shaderElementType.ToString().ToLower());
            materialElement = result.Item1;
            TechniqueName = result.Item2;
        }

        /// <summary>
        /// Set a named parameter
        /// </summary>
        public bool SetValue(string parameterName, dynamic value)
        {
            return MTAClient.DxSetShaderValue(materialElement, parameterName, value);
        }

        /// <summary>
        /// Using tessellation allows a shader to manipulate the shape of the rendered image at each sub-division boundary.
        /// </summary>
        public bool SetTessellation(Vector2 tesselation)
        {
            return MTAClient.DxSetShaderTessellation(materialElement, (int) tesselation.X, (int) tesselation.Y);
        }

        /// <summary>
        /// This function applies a 3D transformation to a shader element when it is drawn with dxDrawImage.
        /// </summary>
        public bool SetTransform(Vector3 rotation, Vector3 rotationCenterOffset, Vector2 perspectiveCenterOffset, bool rotationCenterOffsetOriginIsScreen = false, bool perspectiveCenterOffsetOriginIsScren = false)
        {
            return MTAClient.DxSetShaderTransform(materialElement, rotation.X, rotation.Y, rotation.Z, rotationCenterOffset.X, rotationCenterOffset.Y, rotationCenterOffset.Z, rotationCenterOffsetOriginIsScreen, perspectiveCenterOffset.X, perspectiveCenterOffset.Y, perspectiveCenterOffsetOriginIsScren);
        }

        /// <summary>
        /// Set a 3D transformation without screen transform
        /// </summary>
        /// <returns></returns>
        public bool SetTransform(Vector3 rotation, Vector3 rotationCenterOffset, bool rotationCenterOffsetOriginIsScreen = false)
        {
            return SetTransform(rotation, rotationCenterOffset, Vector2.Zero, rotationCenterOffsetOriginIsScreen);
        }

        /// <summary>
        /// Set a 3D transformation without center offset
        /// </summary>
        public bool SetTransform(Vector3 rotation)
        {
            return SetTransform(rotation, Vector3.Zero);
        }

        /// <summary>
        /// Applies shader to a specific element
        /// </summary>
        /// <param name="textureName"></param>
        /// <param name="targetElement"></param>
        /// <param name="appendLayers"></param>
        /// <returns></returns>
        public bool Apply(string textureName, Element targetElement, bool appendLayers = false)
        {

            return MTAClient.EngineApplyShaderToWorldTexture(this.materialElement, textureName, targetElement.MTAElement, appendLayers);
        }

        /// <summary>
        /// Applies shader to all elements
        /// </summary>
        /// <param name="textureName"></param>
        /// <param name="appendLayers"></param>
        /// <returns></returns>
        public bool Apply(string textureName, bool appendLayers = false)
        {

            return Apply(textureName, Element.Root, appendLayers);
        }

        /// <summary>
        /// Removes shader from a specific element
        /// </summary>
        /// <param name="textureName"></param>
        /// <param name="targetElement"></param>
        /// <returns></returns>
        public bool Remove(string textureName, Element targetElement)
        {
            return MTAClient.EngineRemoveShaderFromWorldTexture(this.materialElement, textureName, targetElement.MTAElement);
        }

        /// <summary>
        /// Removes shader from all elements
        /// </summary>
        /// <param name="textureName"></param>
        /// <returns></returns>
        public bool Remove(string textureName)
        {
            return Remove(textureName, Element.Root);
        }
    }
}
