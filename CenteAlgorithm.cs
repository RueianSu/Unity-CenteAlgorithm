using System.Collections.Generic;
using UnityEngine;

namespace Cente
{
    public class CenteAlgorithm : MonoBehaviour
    {
        public static Vector2 GetCente(List<Vector2> Points)
        {
            int total = Points.Count;
            double lat = 0, lon = 0;
            foreach (Vector2 p in Points)
            {
                lat += p.x;
                lon += p.y;      
            }
            lat /= total;
            lon /= total;
            Vector2 centerPoint = new Vector2((float)lat, (float)lon);
            return centerPoint;
        }
    }
}
