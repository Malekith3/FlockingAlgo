using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FilteredFlockBehaviour : FlockBehavior
{
    [SerializeField] protected ContextFilter filter;
}
