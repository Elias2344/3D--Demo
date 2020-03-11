using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectile;

    public float fireDelay = 1f;

    private float timeSinceLastFire = 0f;

    public float playerSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Input.GetAxis("Vertical");   
        float HorizontalMovement = Input.GetAxis("Horizontal");   
        
       /*  if (verticalMovement != 0f) {
            Vector2 newPosition = new Vector2(0f, (verticalMovement * 0.1f));
            transform.Translate(newPosition);

        }
        if (HorizontalMovement != 0) {
            Vector2 newPosition = new Vector2(HorizontalMovement * 0.1f, 0f);
            transform.Translate(newPosition);
        } */

        if(verticalMovement != 0f || HorizontalMovement != 0f) {
            Vector2 newPosition = newPosition = new Vector2(HorizontalMovement * playerSpeed, verticalMovement * playerSpeed);
            transform.Translate(newPosition);
        }

        //Time.deltatime

        //Agregar tiempo del ultimo frame al tiempo transcurrido
             timeSinceLastFire += Time.deltaTime;

        //Solamente se puede disparar si ya paso el tiempo definido
        if (timeSinceLastFire >= fireDelay) {
            //Can shoot
             if (Input.GetButton("Fire1")) {
            Debug.Log("Pew");

            Instantiate(projectile,transform.position + new Vector3(0f, 1f, 0f) * 1f,transform.rotation);
            timeSinceLastFire = 0f;

            }
        }
           

        // if (Input.GetKeyDown(KeyCode.Space)) {
           

            /* projectile.transform.Translate(
                new Vector3(
                transform.position.x, 
                transform.position.y,
                transform.position.z
                )
            ); */

        }
    }

