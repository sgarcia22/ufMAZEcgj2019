using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Interactable : MonoBehaviour
{
    // Returns true if the player's position is within the set radius of the interactable's position
    public abstract bool PlayerWithinRadius();
    
    // Performs an interaction.
    public abstract void Interact();
}
