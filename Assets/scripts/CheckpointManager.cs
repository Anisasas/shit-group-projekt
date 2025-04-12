using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public static Vector3 lastCheckpointPos;

    void Start()
    {
        // Pradžioje nustatome esamą poziciją kaip pirmąjį checkpointą
        lastCheckpointPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    }
}
