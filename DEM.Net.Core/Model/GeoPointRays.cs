﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DEM.Net.Core
{
    public class GeoPointRays : GeoPoint
    {
        public List<Vector3> Rays { get; set; } = new List<Vector3>();
        public Vector3 Normal { get; set; }

        public GeoPointRays(double latitude, double longitude, double? altitude, Vector3 normal, float left, float right, float up, float down)
            : base(latitude, longitude, altitude)
        {
            this.Normal = normal;
            this.Rays.Add(Vector3.UnitX * left * -1F);
            this.Rays.Add(Vector3.UnitX * right * 1F);
            this.Rays.Add(Vector3.UnitZ * down * -1F);
            this.Rays.Add(Vector3.UnitZ * up * 1F);
        }
    }
}
