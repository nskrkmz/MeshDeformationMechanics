using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(
    typeof(MeshFilter),
    typeof(MeshRenderer)
    )]
class CreatTriangle : MonoBehaviour, IMeshCreatable
{
    [SerializeField] private Material mat;

    Vector3[] vertices;
    int[] triangles;
    Mesh mesh;

    private void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        CreateMeshData();
        CreateMesh();
        GetComponent<MeshRenderer>().material = mat;
    }
    public void CreateMeshData()
    {
        vertices = new Vector3[]{
            Vector3.zero,
            Vector3.forward,
            Vector3.right
        };

        triangles = new int[]{
            0,1,2
        };
    }
    public void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = this.vertices;
        mesh.triangles = this.triangles;
        mesh.RecalculateNormals();
    }

    
}

