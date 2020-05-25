using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
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
            Tuple<MtaElement, string> result = MtaClient.DxCreateShader(filePathOrRaw, priority, maxDistance, layered, shaderElementType.ToString().ToLower());
            materialElement = result.Item1;
            TechniqueName = result.Item2;
        }

        /// <summary>
        /// Set a named parameter
        /// </summary>
        public bool SetValue(string parameterName, dynamic value)
        {
            return MtaClient.DxSetShaderValue(materialElement, parameterName, value);
        }

        /// <summary>
        /// Set a named parameter to compound values
        /// </summary>
        public bool SetValue(string parameterName, params dynamic[] values)
        {
            /*
            [[
                do
	                return SlipeMtaDefinitions.MtaClient.DxSetShaderValue(this.materialElement, parameterName, unpack(values))
                end
            ]]
            */
            return MtaClient.DxSetShaderValue(materialElement, parameterName, values);
        }

        /// <summary>
        /// Using tessellation allows a shader to manipulate the shape of the rendered image at each sub-division boundary.
        /// </summary>
        public bool SetTessellation(Vector2 tesselation)
        {
            return MtaClient.DxSetShaderTessellation(materialElement, (int) tesselation.X, (int) tesselation.Y);
        }

        /// <summary>
        /// This function applies a 3D transformation to a shader element when it is drawn with dxDrawImage.
        /// </summary>
        public bool SetTransform(Vector3 rotation, Vector3 rotationCenterOffset, Vector2 perspectiveCenterOffset, bool rotationCenterOffsetOriginIsScreen = false, bool perspectiveCenterOffsetOriginIsScren = false)
        {
            return MtaClient.DxSetShaderTransform(materialElement, rotation.X, rotation.Y, rotation.Z, rotationCenterOffset.X, rotationCenterOffset.Y, rotationCenterOffset.Z, rotationCenterOffsetOriginIsScreen, perspectiveCenterOffset.X, perspectiveCenterOffset.Y, perspectiveCenterOffsetOriginIsScren);
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
            return MtaClient.EngineApplyShaderToWorldTexture(this.materialElement, textureName, targetElement.MTAElement, appendLayers);
        }

        /// <summary>
        /// Applies shader to all elements
        /// </summary>
        /// <param name="textureName"></param>
        /// <param name="appendLayers"></param>
        /// <returns></returns>
        public bool Apply(string textureName, bool appendLayers = false)
        {
            return MtaClient.EngineApplyShaderToWorldTexture(this.materialElement, textureName, null, appendLayers);
        }

        /// <summary>
        /// Removes shader from a specific element
        /// </summary>
        /// <param name="textureName"></param>
        /// <param name="targetElement"></param>
        /// <returns></returns>
        public bool Remove(string textureName, Element targetElement)
        {
            return MtaClient.EngineRemoveShaderFromWorldTexture(this.materialElement, textureName, targetElement.MTAElement);
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
