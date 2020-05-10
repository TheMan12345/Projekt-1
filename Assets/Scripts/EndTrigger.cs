using UnityEngine;

public class EndTrigger : MonoBehaviour{

    public Manager manager;

        void OnTriggerEnter ()
        {
        manager.CompleteLevel();
        }

}
