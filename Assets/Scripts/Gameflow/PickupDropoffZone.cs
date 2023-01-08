using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupDropoffZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            PickedUpAction pickedUp = other.gameObject.GetComponent<PickedUpAction>();

            switch (pickedUp.itemType)
            {
                case Items.Chest:
                    ObjectiveStatic.ObjectivesStatic.SignalChestPutInVan();
                    break;
                case Items.Ring:
                    ObjectiveStatic.ObjectivesStatic.SignalRingPutInVan();
                    break;
                case Items.Cup:
                    ObjectiveStatic.ObjectivesStatic.SignalCupPutInVan();
                    break;
                case Items.Monkey:
                    ObjectiveStatic.ObjectivesStatic.SignalMonkeyPutInVan();
                    break;
                case Items.Nothing:
                case Items.Shovel:
                default:
                    break;
            }
        }

        if (other.gameObject.tag == "Player")
        {
            if (ObjectiveStatic.ObjectivesStatic.IsGameComplete())
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene("GameWonScene");
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (ObjectiveStatic.ObjectivesStatic.IsGameComplete())
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene("GameWonScene");
            }
        }
    }
}
