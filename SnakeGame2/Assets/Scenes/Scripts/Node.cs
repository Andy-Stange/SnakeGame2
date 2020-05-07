using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snakes
{
    public class Node
    {
        public int x;
        public int y;
        public Vector3 worldPosition;

        public Node(int num1, int num2, Vector3 vec)
        {
            x = num1;
            y = num2;
            worldPosition = vec;
        }
        public Node()
        {

        }
    }
}
