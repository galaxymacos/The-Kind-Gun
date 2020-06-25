using UnityEngine;

public class SwordQi : MonoBehaviour
{
    private Vector3 flyDir;
    [SerializeField] private float speed = 20f;
    
    private void Awake()
    {
        Vector3 mousePos = UtilityClass.mouseWorldPos;
        flyDir = (mousePos - transform.position).normalized;
        flyDir.z = 0;
        transform.rotation = Quaternion.FromToRotation(Vector3.right, flyDir);
        
    }

    private void Update()
    {
        transform.Translate(flyDir * (speed * Time.deltaTime), Space.World);
    }
}