
using UnityEngine;

public class Collider : MonoBehaviour

{
    public Move Movement;
        void OnCollisionEnter(UnityEngine.Collision collisionInfo){
            if (collisionInfo.collider.tag == "Obstacle"){
            Movement.enabled = false;
            FindObjectOfType<Manager>().EndGame();
        }

    }

}
