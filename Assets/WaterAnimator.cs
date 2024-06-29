using UnityEngine;

public class FoamAnimator : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public Material waterMaterial; // Reference to the material with the water shader

    void Update()
    {
        // Get the value of the "FoamAmount" parameter from the Animator
        float foamAmount = animator.GetFloat("Foam Amount");

        // Set the "_FoamAmount" property of the material to this value
        waterMaterial.SetFloat("Foam Amount", foamAmount);
    }
}


