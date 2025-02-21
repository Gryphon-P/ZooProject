using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControlScript : MonoBehaviour
{

    private IInteractable IinteractableInstance;

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
    }

    // Sets the instance
    public void SetIInstance(IInteractable interactable) {
        IinteractableInstance = interactable;
    }

    // Clears the instance
    public void ClearIInstance() {
        IinteractableInstance = null;
    }

}
