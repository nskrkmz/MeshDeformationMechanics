using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(
    typeof(MeshRenderer),
    typeof(MeshFilter)
    )]
public class CreatProceduralGrid : MonoBehaviour
{
    [Header("Grid Settings")]
    public float cellSize;
    public Vector3 gridOffset;
    public int gridSize;

    [Header("Material")]
    [SerializeField] private Material mat;

    Vector3[] vertices;
    int[] triangles;
    Mesh mesh;

    private void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    void Start()
    {

        CreatGrid();
        UpdateMesh();
        GetComponent<MeshRenderer>().material = mat;

    }

    public void CreatGrid()
    {
        //Set vertex sizes

        //Set vertex offset

        //populate the vertices and triangles arrays
        
    }

    public void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }
}
