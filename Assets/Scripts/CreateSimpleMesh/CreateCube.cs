using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(
    typeof(MeshRenderer),
    typeof(MeshFilter)
    )]
public class CreateCube : MonoBehaviour, IMeshCreatable
{ 
    [SerializeField] Material mat;
    Vector3[] vertices;
    int[] triangles;

    Mesh mesh;

    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;

        CreateMeshData();
        CreateMesh();
        GetComponent<MeshRenderer>().material = mat;

    }

    public void CreateMeshData()
    {
        vertices = new Vector3[]{
            new Vector3(0,0,0),
            new Vector3(0,1,0),
            new Vector3(1,0,0),
            new Vector3(1,1,0),
            new Vector3(1,0,1),
            new Vector3(1,1,1),
            new Vector3(0,0,1),
            new Vector3(0,1,1),
        };

        triangles = new int[]{
            0,1,2,
            1,3,2,
            2,3,4,
            3,5,4,
            4,5,6,
            5,7,6,
            6,7,0,
            7,1,0,
            5,3,7,
            3,1,7,
            0,6,2,
            6,4,2
        };
    }

    public void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }
}
