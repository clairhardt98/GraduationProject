using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.IO;

public class MeshMaker : MonoBehaviour
{
    int sample_number = 3;
    string XYZ_directory = "Assets/Resources/PC.txt";

    List<Vector3> vertices = new List<Vector3>();
    public GameObject depth_mesh;
    //MeshFilter mesh_filter;
    MeshRenderer Mesh_render;
    Mesh mesh;
    MeshCollider mesh_collider;

    //Vector3[] sub_vertices;
    int cnt = 0;
    private void Start()
    {
        StartCoroutine(MakeMesh(Screen.width*6, Screen.height));
        Debug.Log(Screen.width);
    }

    private IEnumerator MakeMesh(int renderSizeX, int renderSizeY)
    {
        yield return new WaitForEndOfFrame();

        mesh = new Mesh();
        Mesh_render = depth_mesh.GetComponent<MeshRenderer>();
        //mesh_filter = depth_mesh.AddComponent<MeshFilter>();
        //Mesh_render = depth_mesh.AddComponent<MeshRenderer>();
        mesh_collider = depth_mesh.GetComponent<MeshCollider>();

        int num_vertices = (renderSizeX/sample_number) * (renderSizeY/sample_number);
        int[,] TwoD_indices = new int[renderSizeX / sample_number, renderSizeY / sample_number];
        

        ReadPCtoVertices();//포인트 클라우드 읽어오기
        
        mesh.vertices = vertices.ToArray();
        Debug.Log("Reading Point Cloud done");
        Debug.Log(cnt);

        for (int row = 0; row < renderSizeX / sample_number; row++)
        {
            for (int col = 0; col < renderSizeY / sample_number; col++)
            {
                TwoD_indices[row, col] = (renderSizeY / sample_number) * row + col;
            }
        }

        List<int> triangles = new List<int>();
        for (int row = 1; row < (renderSizeX / sample_number) - 1; row++)
        {
            for (int col = 1; col < (renderSizeY / sample_number) - 1; col++)
            {
                triangles.Add(TwoD_indices[row, col]);
                triangles.Add(TwoD_indices[row + 1, col]);
                triangles.Add(TwoD_indices[row, col + 1]);


                triangles.Add(TwoD_indices[row, col]);
                triangles.Add(TwoD_indices[row - 1, col]);
                triangles.Add(TwoD_indices[row, col - 1]);

            }
        }
        triangles.Reverse();
        
        mesh.triangles = triangles.ToArray();
        Debug.Log("Setting triangles done");

        Vector2[] uv = new Vector2[num_vertices];
        for (int row = 0; row < (renderSizeX / sample_number); row++)
        {
            for (int col = 0; col < (renderSizeY / sample_number); col++)
            {
                float render_x = (float)renderSizeX / (float)sample_number;
                float render_y = (float)renderSizeY / (float)sample_number;

                uv[(renderSizeY / sample_number) * row + col] = new Vector2((float)((float)row / render_x), (float)((float)col / render_y));

            }
        }
        mesh.uv = uv;
        Debug.Log("Setting uv done");

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        /*for (int n = 0; n < mesh.normals.Length; n++)
        {
            mesh.normals[n] = -mesh.normals[n];
        }*/

        depth_mesh.GetComponent<MeshFilter>().mesh = mesh;
        
        mesh_collider.sharedMesh = mesh;
        mesh_collider.convex = true;

        yield return 0;

    }
    public void ReadPCtoVertices()
    {
        //Point cloud 텍스트 파일 열어서 점들을 vertices에 입력
        FileStream ReadXYZ = new FileStream(XYZ_directory, FileMode.Open);
        StreamReader Reader = new StreamReader(ReadXYZ);
        
        while (Reader.EndOfStream==false)
        {
            StringToVector3(Reader.ReadLine());
            cnt++;
        }
        Reader.Close();
    }
    public void StringToVector3(string sVector)
    {
        //string을 vector3로 변환해줌
        string[] sArray = sVector.Split(' ');
        Vector3 worldPoint = new Vector3(
            float.Parse(sArray[0])+'f',
            float.Parse(sArray[1])+'f',
            float.Parse(sArray[2])+'f');

        //Debug.Log(cnt++);
        vertices.Add(worldPoint); 
    }
    
}
