﻿using System;

namespace LinkedLists
{
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

            //Constructor
            public Node(int value)
            {
                Value = value;
            }
        }
}