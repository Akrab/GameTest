﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PG
{
    public class DontDestroyOnLoad :MonoBehaviour
    {
        void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }    
    }
}
