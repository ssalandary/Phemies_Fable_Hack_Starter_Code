using UnityEngine;


namespace Phemis_Fable_Hack
{
    partial class HackMain : MonoBehaviour
    {
        public void Start()
        {   // This function is called once for each instance of this class,
            // when it starts execution (in this case, attached to an object)
        }

        public void Update()
        {   // This function is called once per frame, it's frequency depends on the frame rate.
            // This is at the beginning of the game logic cycle.
        }
        public void LateUpdate()
        {   // This function is called once per frame, it's frequency depends on the frame rate.
            // This is at the end of the game logic cycle.
        }

        public void OnGUI()
        {   // This function is called at the end of the frame, after all game logic.
            // It is called twice per frame: Once for rendering, and once for GUI Events
            // This is where we do all drawing operations
        }


        /* - Physics Method - */
        public void FixedUpdate()
        {   // This function is called at a fixed frequency (Typically 100hz) and is independent of the frame rate.
            // For physics operations.
        }
    }
}
