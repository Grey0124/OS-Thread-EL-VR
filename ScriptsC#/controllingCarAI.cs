using UnityEngine;

public class controllingCarAI : MonoBehaviour
{
    
    private int index;
    public CarAI carAI;
    
    void variables()
    {
        
        carAI.Patrol = true;
        
        carAI.Patrol = false;

        carAI.MaxSteeringAngle = 45;

        carAI.MaxRPM = 150;

        
        carAI.NavMeshLayers[index] = "LayerName";

      
        carAI.ShowGizmos = true;
        
        carAI.ShowGizmos = false;

        
        carAI.move = true;
      
        carAI.move = false;
    }

    void Methods()
    {
        
        carAI.RandomPath();

        
        carAI.CustomPath(gameObject.transform);
    }
}
