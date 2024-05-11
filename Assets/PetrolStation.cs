using UnityEngine;

public class FuelStation : MonoBehaviour
{
    public float refuelRate = 0.5f; // Amount of fuel per second
    public float maxFuel = 100f; // Maximum fuel capacity of the bus
    public float currentFuel = 0f; // Current fuel level of the bus

    private bool isRefueling = false;
    private GameObject bus; // Reference to the bus GameObject

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bus"))
        {
            bus = other.gameObject;
            isRefueling = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bus"))
        {
            isRefueling = false;
        }
    }

    private void Update()
    {
        if (isRefueling && currentFuel < maxFuel)
        {
            Refuel();
        }
    }

    private void Refuel()
    {
        currentFuel += refuelRate * Time.deltaTime;
        currentFuel = Mathf.Clamp(currentFuel, 0f, maxFuel);

        // Update the fuel level of the bus (You may have a separate script to handle this)
        // For example, if the bus has a FuelController script:
        // bus.GetComponent<FuelController>().SetFuelLevel(currentFuel);

        if (currentFuel >= maxFuel)
        {
            isRefueling = false;
            Debug.Log("Fuel tank is full. Refueling stopped.");
        }
    }
}
