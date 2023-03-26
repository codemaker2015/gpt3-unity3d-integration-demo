

using UnityEngine;
using UnityEditor;

public class DoTaskScript
{
    [MenuItem("Edit/Do Task")]
    static void DoTask()
    {
        GameObject particleSystemObj = new GameObject("Particle System");
        particleSystemObj.AddComponent<ParticleSystem>();
    }
}