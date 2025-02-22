using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControlScript : MonoBehaviour
{

    public IInteractable IinteractableInstance;
    public IPet IpetInstance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {

            if (IinteractableInstance != null) {
                IinteractableInstance.interact();
            }
        }


        if (Input.GetKeyDown(KeyCode.P)) {
            if (IpetInstance != null) {
                IpetInstance.pet();
            }
        }

        Debug.Log(IpetInstance);
    }

    // Sets the instance
    public void SetIInstance(IInteractable interactable) {
        IinteractableInstance = interactable;
    }

    public void SetIPet(IPet petInstance) {
        IpetInstance = petInstance;
    }

    // Clears the instance
    public void ClearIInstance() {
        IinteractableInstance = null;
    }

    public void ClearIPet() {
        IpetInstance = null;
    }

}
