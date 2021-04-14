using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managar : MonoBehaviour
{                                            
    [SerializeField] Rotator rotator;        
    [SerializeField] PinSpawner pinSpawner;  
    [SerializeField] CameraAnimator animator;
                                             
    public void GameOver()                   
    {                                        
          DisableGameElements();
        animator.SetGameOverTrigger();
    }                                        
                                             
    public void LevelComplete()              
    {                                        
        DisableGameElements();
        animator.SetLevelCompleteTrigger();
    }        
    
    private void DisableGameElements()
    {
        rotator.enabled = false;
        pinSpawner.enabled = false;
    }
}
