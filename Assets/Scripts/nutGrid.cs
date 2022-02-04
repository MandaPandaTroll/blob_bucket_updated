using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class nutGrid
{

    private int width;
    private int height;
    private float cellSize;
    private Vector3 originPosition;
    public int[,] gridArray;
    private TextMesh[,] debugTextArray;
   
    Color numberCol = new Color(1.0f, 1.0f, 1.0f, 1.0f);
 public nutGrid(int width, int height, float cellSize, Vector3 originPosition)
    {
     this.width = width;
     this.height = height;
     this.cellSize = cellSize;
     this.originPosition = originPosition;

     gridArray = new int[width, height];
             for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for(int y = 0; y < gridArray.GetLength(1); y++)
            {
               
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white, 10f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x +1, y), Color.white, 10f);
            }
        }
        Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 10f);
        Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 10f);
        

    }



    private Vector3 GetWorldPosition(int x, int y){
        return new Vector3 (x, y)*cellSize + originPosition;
    }

    private void GetXY(Vector3 worldPosition, out int x, out int y){

        x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
        y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
    
    }
    public void SetValue(int x, int y, int value){
        if(x >= 0 && y >= 0 && x < width && y < height){
            gridArray[x, y] = value;
            
        }
    }


        public void SetValue(Vector3 worldPosition, int value){
        int x, y;
        GetXY(worldPosition, out x, out y);
        SetValue(x, y, value);

    }

    public int GetValue(int x, int y) {
        if(x >= 0 && y >= 0 && x < width && y < height){
            return gridArray[x , y];
        }else {
            return 0;
        }
    }

    public int GetValue(Vector3 worldPosition) {
        int x, y;
        GetXY(worldPosition, out x, out y);
        return GetValue(x, y);
    }
    

} 

