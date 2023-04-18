using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

namespace MoreMountains.TopDownEngine
{
    [AddComponentMenu("TopDown Engine/Character/AI/Decisions/AIDecisionTankAlly")]
    //[RequireComponent(typeof(Character))]
    public class AIDecisionTankAlly : AIDecision
    {

        // Start is called before the first frame update
        public override bool Decide()
        {
            return WaitBoss();
        }
       
        // Update is called once per frame
        protected virtual bool WaitBoss()
        {   
            GameObject[] tankers = GameObject.FindGameObjectsWithTag("Tanker");
            if( tankers.Length > 0)
            {
                Debug.Log("co tank");
                return true;
            }
            Debug.Log("no tank");
            return false;
        }
    }
}