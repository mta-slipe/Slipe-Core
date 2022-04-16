using SlipeLua.MtaDefinitions;
using SlipeLua.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SlipeLua.Client.Dx
{
    public static class Dx
    {
        #region Circle
        public static bool DrawCircle(Vector2 position, float radius, Color color, Color centerColor, float startAngle = 0, float stopAngle = 360, int segments = 32, int ratio = 1, bool postGui = false)
        {
            return MtaClient.DxDrawCircle(position.X, position.Y, radius, startAngle, stopAngle, color.Hex, centerColor.Hex, segments, ratio, postGui);
        }

        public static bool DrawCircle(Vector2 position, float radius, Color color)
        {
            return DrawCircle(position, radius, color, color);
        }

        public static bool DrawCircle(Vector2 position, float radius)
        {
            return DrawCircle(position, radius, Color.White);
        }
        #endregion

        #region Image
        public static bool DrawImage(string filePath, Vector2 position, Vector2 dimensions, Color color, Vector2 rotationCenterOffset, float rotation = 0,  bool postGui = false)
        {
            return MtaClient.DxDrawImage(position.X, position.Y, dimensions.X, dimensions.Y, filePath, rotation, rotationCenterOffset.X, rotationCenterOffset.Y, color.Hex, postGui);
        }

        public static bool DrawImage(string filePath, Vector2 position, Vector2 dimensions, Color color)
        {
            return DrawImage(filePath, position, dimensions, color, Vector2.Zero);
        }

        public static bool DrawImage(string filePath, Vector2 position, Vector2 dimensions)
        {
            return DrawImage(filePath, position, dimensions, Color.White);
        }

        public static bool DrawImage(Material material, Vector2 position, Vector2 dimensions, Color color, Vector2 rotationCenterOffset, float rotation = 0, bool postGui = false)
        {
            return MtaClient.DxDrawImage(position.X, position.Y, dimensions.X, dimensions.Y, material?.MaterialElement, rotation, rotationCenterOffset.X, rotationCenterOffset.Y, color.Hex, postGui);
        }

        public static bool DrawImage(Material material, Vector2 position, Vector2 dimensions, Color color)
        {
            return DrawImage(material, position, dimensions, color, Vector2.Zero);
        }

        public static bool DrawImage(Material material, Vector2 position, Vector2 dimensions)
        {
            return DrawImage(material, position, dimensions, Color.White);
        }
        #endregion

        #region ImageSection
        public static bool DrawImageSection(string filePath, Vector2 position, Vector2 dimensions, Vector2 topLeft, Vector2 size, Color color, Vector2 rotationCenterOffset, float rotation = 0, bool postGui = false)
        {
            return MtaClient.DxDrawImageSection(position.X, position.Y, dimensions.X, dimensions.Y, topLeft.X, topLeft.Y, size.X, size.Y, filePath, rotation, rotationCenterOffset.X, rotationCenterOffset.Y, color.Hex, postGui);
        }

        public static bool DrawImageSection(string filePath, Vector2 position, Vector2 dimensions, Vector2 topLeft, Vector2 size, Color color)
        {
            return DrawImageSection(filePath, position, dimensions, topLeft, size, color, Vector2.Zero);
        }

        public static bool DrawImageSection(string filePath, Vector2 position, Vector2 dimensions, Vector2 topLeft, Vector2 size)
        {
            return DrawImageSection(filePath, position, dimensions, topLeft, size, Color.White);
        }

        public static bool DrawImageSection(Material material, Vector2 position, Vector2 dimensions, Vector2 topLeft, Vector2 size, Color color, Vector2 rotationCenterOffset, float rotation = 0, bool postGui = false)
        {
            return MtaClient.DxDrawImageSection(position.X, position.Y, dimensions.X, dimensions.Y, topLeft.X, topLeft.Y, size.X, size.Y, material?.MaterialElement, rotation, rotationCenterOffset.X, rotationCenterOffset.Y, color.Hex, postGui);
        }

        public static bool DrawImageSection(Material material, Vector2 position, Vector2 dimensions, Vector2 topLeft, Vector2 size, Color color)
        {
            return DrawImageSection(material, position, dimensions, topLeft, size, color, Vector2.Zero);
        }

        public static bool DrawImageSection(Material material, Vector2 position, Vector2 dimensions, Vector2 topLeft, Vector2 size)
        {
            return DrawImageSection(material, position, dimensions, topLeft, size, Color.White);
        }
        #endregion

        #region Line
        public static bool DrawLine(Vector2 startPosition, Vector2 endPosition, Color color, float width = 1, bool postGui = false)
        {
            return MtaClient.DxDrawLine((int) startPosition.X, (int)startPosition.Y, (int)endPosition.X, (int)endPosition.Y, color.Hex, width, postGui);
        }
        #endregion

        #region 3D Line
        public static bool DrawLine3D(Vector3 startPosition, Vector3 endPosition, Color color, float width = 1, bool postGui = false)
        {
            return MtaClient.DxDrawLine3D(startPosition.X, startPosition.Y, startPosition.Z, endPosition.X, endPosition.Y, endPosition.Z, color.Hex, width, postGui);
        }
        #endregion

        #region Material 3D Line
        public static bool DrawMaterialLine3D(Material material, Vector3 startPosition, Vector3 endPosition, Color color, float width = 1, bool postGui = false)
        {
            return MtaClient.DxDrawMaterialLine3D(startPosition.X, startPosition.Y, startPosition.Z, endPosition.X, endPosition.Y, endPosition.Z, material?.MaterialElement, color.Hex, (int)width, postGui);
        }

        public static bool DrawMaterialLine3D(Material material, Vector3 startPosition, Vector3 endPosition, Vector3 faceToward, Color color, float width = 1, bool postGui = false)
        {
            return MtaClient.DxDrawMaterialLine3D(startPosition.X, startPosition.Y, startPosition.Z, endPosition.X, endPosition.Y, endPosition.Z, material?.MaterialElement, color.Hex, (int)width, postGui, faceToward.X, faceToward.Y, faceToward.Z);
        }
        #endregion

        #region Material Primitive
        public static bool DrawMaterialPrimitive(PrimitiveType primitiveType, Material material, List<Vertice> vertices, bool postGui = false)
        {
            return DrawMaterialPrimitiveWithMaterial(primitiveType, material?.MaterialElement, vertices, postGui);
        }

        public static bool DrawMaterialPrimitive(PrimitiveType primitiveType, string path, List<Vertice> vertices, bool postGui = false)
        {
            return DrawMaterialPrimitiveWithMaterial(primitiveType, path, vertices, postGui);
        }

        private static bool DrawMaterialPrimitiveWithMaterial(PrimitiveType primitiveType, dynamic pathOrMaterial, List<Vertice> vertices, bool postGui = false)
        {
            List<Vector2> vectors = new List<Vector2>();
            List<int> colors = new List<int>();
            List<Vector2> topLefts = new List<Vector2>();

            foreach (Vertice vertice in vertices)
            {
                vectors.Add(vertice.Position);
                colors.Add(vertice.Color.Hex);
                topLefts.Add(vertice.TopLeft);
            }

            return MtaClient.DxDrawMaterialPrimitive(primitiveType.ToString().ToLower(), pathOrMaterial, postGui, vertices.Count, vectors, colors, topLefts);
        }
        #endregion

        #region Primitive
        public static bool DrawPrimitive(PrimitiveType primitiveType, List<Vertice> vertices, bool postGui = false)
        {
            List<Vector2> vectors = new List<Vector2>();
            List<int> colors = new List<int>();

            foreach (Vertice vertice in vertices)
            {
                vectors.Add(vertice.Position);
                colors.Add(vertice.Color.Hex);
            }

            return MtaClient.DxDrawPrimitive(primitiveType.ToString().ToLower(), postGui, vertices.Count, vectors, colors);
        }
        #endregion

        #region Material Section 3D Line
        public static bool DrawMaterialSectionLine3D(Material material, Vector3 startPosition, Vector3 endPosition, Vector2 topLeft, Vector2 size, Color color, float width = 1, bool postGui = false)
        {
            return MtaClient.DxDrawMaterialSectionLine3D(startPosition.X, startPosition.Y, startPosition.Z, endPosition.X, endPosition.Y, endPosition.Z, topLeft.X, topLeft.Y, size.X, size.Y, material?.MaterialElement, color.Hex, (int)width, postGui);
        }

        public static bool DrawMaterialSectionLine3D(Material material, Vector3 startPosition, Vector3 endPosition, Vector3 faceToward, Vector2 topLeft, Vector2 size, Color color, float width = 1, bool postGui = false)
        {
            return MtaClient.DxDrawMaterialSectionLine3D(startPosition.X, startPosition.Y, startPosition.Z, endPosition.X, endPosition.Y, endPosition.Z, topLeft.X, topLeft.Y, size.X, size.Y, material?.MaterialElement, color.Hex, (int)width, postGui, faceToward.X, faceToward.Y, faceToward.Z);
        }
        #endregion

        #region Rectangle
        public static bool DrawRectangle(Vector2 position, Vector2 dimensions, Color color, bool postGui = false, bool subPixelPositioning = false)
        {
            return MtaClient.DxDrawRectangle(position.X, position.Y, dimensions.X, dimensions.Y, color.Hex, postGui, subPixelPositioning);
        }
        #endregion

        #region Text
        public static bool DrawText(string text, Vector2 position, Vector2 bottomRight, Color color, Vector2 scale, Font font, HorizontalAlign horizontalAlign, VerticalAlign verticalAlign, float fRotation, Vector2 fRotationCenter, bool clip = false, bool wordBreak = false, bool postGUI = false, bool colorCoded = false, bool subPixelPositioning = false)
        {
            return MtaClient.DxDrawText(text, position.X, position.Y, bottomRight.X, bottomRight.Y, color.Hex, scale.X, scale.Y, font.MTAFont, horizontalAlign.ToString().ToLower(), verticalAlign.ToString().ToLower(), clip, wordBreak, postGUI, colorCoded, subPixelPositioning, fRotation, fRotationCenter.X, fRotationCenter.Y);
        }

        public static bool DrawText(string text, Vector2 position, Vector2 bottomRight, Color color, Vector2 scale, Font font, HorizontalAlign horizontalAlign = HorizontalAlign.Left, VerticalAlign verticalAlign = VerticalAlign.Top, float fRotation = 0.0f)
        {
            return DrawText(text, position, bottomRight, color, scale, font, horizontalAlign, verticalAlign, fRotation, Vector2.Zero);
        }

        public static bool DrawText(string text, Vector2 position, Vector2 bottomRight, Color color, Vector2 scale, StandardFont font, HorizontalAlign horizontalAlign, VerticalAlign verticalAlign, float fRotation, Vector2 fRotationCenter, bool clip = false, bool wordBreak = false, bool postGUI = false, bool colorCoded = false, bool subPixelPositioning = false)
        {
            return MtaClient.DxDrawText(text, position.X, position.Y, bottomRight.X, bottomRight.Y, color.Hex, scale.X, scale.Y, font.ToString().ToLower(), horizontalAlign.ToString().ToLower(), verticalAlign.ToString().ToLower(), clip, wordBreak, postGUI, colorCoded, subPixelPositioning, fRotation, fRotationCenter.X, fRotationCenter.Y);
        }

        public static bool DrawText(string text, Vector2 position, Vector2 bottomRight, Color color, Vector2 scale, StandardFont font, HorizontalAlign horizontalAlign = HorizontalAlign.Left, VerticalAlign verticalAlign = VerticalAlign.Top, float fRotation = 0.0f)
        {
            return DrawText(text, position, bottomRight, color, scale, font, horizontalAlign, verticalAlign, fRotation, Vector2.Zero);
        }

        public static bool DrawText(string text, Vector2 position, Vector2 bottomRight, Color color)
        {
            return DrawText(text, position, bottomRight, color, Vector2.One, StandardFont.Default);
        }

        public static bool DrawText(string text, Vector2 position)
        {
            return DrawText(text, position, Vector2.Zero, Color.White);
        }
        #endregion

    }
}
