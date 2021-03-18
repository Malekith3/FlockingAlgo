using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Alighment")]
public class AlighmentBehavior : FilteredFlockBehaviour
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        //if no neighbors , maintain current aliment  
        if (context.Count == 0)
            return agent.transform.up;
        //add all points together and average them 
        Vector2 alighmentMove = Vector2.zero;
        List<Transform> filteredContext = (filter == null) ? context : filter.Filter(agent, context);
        foreach (Transform item in filteredContext)
        {
            alighmentMove += (Vector2)item.transform.up;
        }
        alighmentMove /= context.Count;

        //crerat offset from agent position 
        return alighmentMove;
    }
}
