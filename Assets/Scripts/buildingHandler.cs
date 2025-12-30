using System.Numerics;
using UnityEngine;

public class buildingHandler : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float upDownSpeed;
    Rigidbody2D buildingRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buildingRigidBody = GetComponent<Rigidbody2D>();
        MoveBuilding();

        // after 1 seconds, change the direction from up-down to down-up
        InvokeRepeating("SwitchUpDown", 0.1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchUpDown()
    {
        upDownSpeed = -upDownSpeed;
        buildingRigidBody.linearVelocity = new UnityEngine.Vector2(speed, upDownSpeed);
    }

    void MoveBuilding()
    {
        buildingRigidBody.linearVelocity = new UnityEngine.Vector2(-speed, upDownSpeed);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "BuildingRemover")
        {
            Destroy(gameObject);
        }
    }
}
