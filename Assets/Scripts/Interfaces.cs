using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    int Health { get; set; }
    int Stress { get; set; }
    int Hunger { get; set; }
    int Tired { get; set; }
}

