using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

namespace MoreMountains.TopDownEngine
{
    [AddComponentMenu("TopDown Engine/Character/AI/Decisions/AIDecision2Ally")]
    //[RequireComponent(typeof(Character))]
    public class AIDecision2Ally : AIDecision
    {
        public LayerMask Player;

        // Start is called before the first frame update
        public override bool Decide()
        {
            return WaitBoss();
        }
       
        // Update is called once per frame
        protected virtual bool WaitBoss()
        {   
            Collider[] hitPlayer = Physics.OverlapSphere(transform.position, 4f, Player);
            Debug.Log(hitPlayer);
            if( hitPlayer.Length > 2)
            {
                Debug.Log("co dong minh");
                return true;
            }
            Debug.Log("khong co dong minh");
            return false;
        }
    }
}