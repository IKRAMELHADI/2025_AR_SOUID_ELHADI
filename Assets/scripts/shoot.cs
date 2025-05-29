using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject turret;

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
=======
        if (!GameManager.Instance.gameStarted || GameManager.Instance.gameOver)
            return;

>>>>>>> 43f4865 (Ajout UI)
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray, out hit))
                {
<<<<<<< HEAD
                   
                    turret.GetComponent<TurretAI>().currentTarget = hit.transform.gameObject;
                    turret.GetComponent<TurretAI>().Shoot(hit.transform.gameObject);

                }
            
=======
                    turret.GetComponent<TurretAI>().currentTarget = hit.transform.gameObject;
                    turret.GetComponent<TurretAI>().Shoot(hit.transform.gameObject);

                    GameManager.Instance.AddScore(); //  Ajout du score ici
                }
>>>>>>> 43f4865 (Ajout UI)
            }
        }
    }
}


