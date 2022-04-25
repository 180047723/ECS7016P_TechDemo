/* TERRAIN GENERATOR USES PROCEDURAL GENERATION TECHNIQUE: 
1. PERLIN NOISE
*/

using UnityEngine;

public class TerrainGen : MonoBehaviour
{
    //terrain dimensions
    public int terrainwidth = 256; 
    public int terrainheight = 256; 
    public int terraindepth = 50; 
    public float terrainscale = 20f; 

    //terrain noise dimensions for x y coordinates
    public float terrainNoiseX = 100f; 
    public float terrainNoiseY = 100f; 


    //function gives the noise (X,Y) random values between 0 - 999 
    //numbers need to be float so they dont cause problems
    public void Start()
    {
        terrainNoiseX = Random.Range(0f, 999f); 
        terrainNoiseY = Random.Range(0f, 999f); 

    }

    //this function builds the terrain using the dimensions above

    TerrainData BuildTerrain (TerrainData terrainData)
    {
        terrainData.heightmapResolution = terrainwidth +1; 
        terrainData.size = new Vector3(terrainwidth, terraindepth, terrainheight);

        terrainData.SetHeights(0, 0, BuildTerrainHeights()); 
        return terrainData; 
    }

    //this function builds the terrain height 

    float[,] BuildTerrainHeights()
    {
        float[,]terrainheights = new float[terrainwidth,terrainheight];
        for(int x = 0; x < terrainwidth; x++)
        {
             for(int y = 0; y < terrainheight; y++)
             {
                 terrainheights[x, y] = CalculateTerrainHeight(x, y); 

             }
        } 
       
         return terrainheights; 
        
    }

    // This method calculates the terrain heights using the width, scale and the xy Noise
    //And uses PerlinNoise
   float CalculateTerrainHeight(int x, int y)
   {
       float xCoordinates = (float)x / terrainwidth * terrainscale + terrainNoiseX;
       float yCoordinates = (float)y / terrainwidth * terrainscale + terrainNoiseY;

       return Mathf.PerlinNoise(xCoordinates, yCoordinates); 

   }

    // Updates the terrain
    //This function USES THE PERLIN NOISE (PG TECHNIQUE)
    public void Update()
    {
        Terrain terrain = GetComponent<Terrain>(); 
        terrain.terrainData = BuildTerrain(terrain.terrainData);
       
        //movement of the perlin noise (increase/ decrease number for speed)
        terrainNoiseX += Time.deltaTime * 2f;
       
    }

}
