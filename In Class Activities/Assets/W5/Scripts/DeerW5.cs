using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
public class DeerW5: MonoBehaviour
{
    public Vector3 vector;
    private void Start( Collision other)
    {
        Vector3.MoveTowards(other.gameObject.GetComponent<NavMesh>());
        
    
    
    }
}