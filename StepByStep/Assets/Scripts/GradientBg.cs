// GradientBg.cs
// This script demonstrates how to create a gradient color background for the main camera.
// to use this script:
// 1. have Main Camera is in the scene
// 2. create an Empty GameObject in the scene
// 3. attach this script to the Empty GameObject
// 4. press play
// 5. if you see a green to cyan box, good, now just change the BackgroundPlaneVerteices to fill your camera viewport
using UnityEngine;
using UnityEngine.Rendering;

public class GradientBg : MonoBehaviour
{
    void Start()
    {
        // put the backgorund plane in front of camera (you can change this later);
       

        // position and orient main camera and the background plane 
        
        
        
        Camera.main.clearFlags = CameraClearFlags.SolidColor;

        //set background's plane transform parent to be the camera's transform, so the plane doesnt move as camera moves
        
        // create the background plane
        MeshFilter mf = this.gameObject.AddComponent<MeshFilter>();
        MeshRenderer mr = this.gameObject.AddComponent<MeshRenderer>();
        Material mat = new Material(Shader.Find("Sprites/Default"));

        // set the proper renderering order for the background plane
        mat.renderQueue = ((int)RenderQueue.Background);
        mat.color = Color.white;
        mr.material = mat;
        mr.enabled = true;

        // setting the background plane's 4 corner positions ( you def want to change them later )
        Vector3[] BackgroundPlaneVerteices = new Vector3[4];
        BackgroundPlaneVerteices[0] = new Vector3(-300, -300, 0) * 0.25f;
        BackgroundPlaneVerteices[1] = new Vector3(300, -300, 0) * 0.25f;
        BackgroundPlaneVerteices[2] = new Vector3(300, 400, 0) * 0.25f;
        BackgroundPlaneVerteices[3] = new Vector3(-300, 400, 0) * 0.25f;

        //define the order in which the vertices in the BackgroundPlaneVerteices shoudl be used to draw the triangle
        int[] trianglesArray = new int[6];
        trianglesArray[0] = 0;
        trianglesArray[1] = 1;
        trianglesArray[2] = 2;
        trianglesArray[3] = 2;
        trianglesArray[4] = 3;
        trianglesArray[5] = 0;

        mf.mesh.vertices = BackgroundPlaneVerteices;
        mf.mesh.triangles = trianglesArray;

        // here to create gradient color 
        Color[] colors = new Color[mf.mesh.vertices.Length];
        colors[0] = Color.magenta;
        colors[1] = Color.magenta;
        colors[2] = Color.cyan;
        colors[3] = Color.cyan;
        mf.mesh.colors = colors;


    }


}