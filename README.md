# CenteAlgorithm


//UNITY 中心演算法 


	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using Mapbox.Utils;
	using UnityEngine;

	public class CenteAlgorithm : MonoBehaviour
	{
    		public Vector2 Calculate_CenterPoint(List<Vector2> Points)
    		{
        		int total = Points.Count;
        		double lat = 0, lon = 0;
        		foreach (Vector2 p in Points)
        		{
           			lat += p.x;// * Mathf.PI / 180;
            			lon += p.y;// * Mathf.PI / 180;        
        		}
        		lat /= total;
        		lon /= total;
        		Vector2 centerPoint = new Vector2(lat, lon);
        		return centerPoint;
    		}
	}