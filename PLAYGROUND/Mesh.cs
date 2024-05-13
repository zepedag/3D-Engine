﻿using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PLAYGROUND
{
    public class Mesh
    {
        // mtx   :: ex rotations
        // mtx   :: position
        // mtx   :: scales

        public List<Vertex> Vertices { get; set; }
        public List<int> Indexes { get; set; }
        public Transform Transform { get; set; }

        public Vertex Center { get; set; }

        public Mesh()
        {
            Vertices = new List<Vertex>();
            Indexes = new List<int>();
            Transform = new Transform();
            // CalculateCenter();
        }

        public void CalculateCenter()
        {
            // Calcula el centro del modelo como el promedio de las coordenadas de los vértices
            float sumX = 0, sumY = 0, sumZ = 0;
            for (int i = 0; i < Vertices.Count; i++)
            {
                sumX += Vertices[i].X;
                sumY += Vertices[i].Y;
                sumZ += Vertices[i].Z;
            }

            int vertexCount = Vertices.Count;
            if (vertexCount > 0)
            {
                Center = new Vertex
                {
                    X = sumX / vertexCount,
                    Y = sumY / vertexCount,
                    Z = sumZ / vertexCount
                };
            }
        }

        public Transform GetCurrentTransform()
        {
            // Simply return the current Transform object
            return Transform;
        }

        public void PrintCenterInfo()
        {
            Console.WriteLine($"Centro del modelo: X={Center.X}, Y={Center.Y}, Z={Center.Z}");
        }

        public void Render()
        {
        }


    }
}
