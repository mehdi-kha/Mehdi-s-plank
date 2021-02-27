using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject VehicleTypeA;

        [SerializeField]
    public GameObject VehicleTypeA2;

        [SerializeField]
    public GameObject VehicleTypeB1;

        [SerializeField]
    public GameObject VehicleTypeB2;

            [SerializeField]
    public GameObject VehicleTypeC1;

            [SerializeField]
    public GameObject VehicleTypeC2;

                [SerializeField]
    public GameObject VehicleTypeD1;

                [SerializeField]
    public GameObject VehicleTypeD2;
    
    [SerializeField]
    public float firstTimer;

    [SerializeField]
    public float secondTimer;

    [SerializeField]
    public float thirdTimer;

    [SerializeField]
    public float fourthTimer;

    private bool isVehicleTypeAInstantiated = false;
    private bool isVehicleTypeBInstantiated = false;
    private bool isVehicleTypeCInstantiated = false;
    private bool isVehicleTypeDInstantiated = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        firstTimer -= Time.deltaTime;
        secondTimer -= Time.deltaTime;
        thirdTimer -= Time.deltaTime;
        fourthTimer -= Time.deltaTime;

        if (firstTimer < 0 && !isVehicleTypeAInstantiated)
        {
            Instantiate(VehicleTypeA);
            Instantiate(VehicleTypeA2);
            isVehicleTypeAInstantiated = true;
        }

                if (secondTimer < 0 && !isVehicleTypeBInstantiated)
        {
            Instantiate(VehicleTypeB1);
            Instantiate(VehicleTypeB2);
            isVehicleTypeBInstantiated = true;
        }

                if (thirdTimer < 0 && !isVehicleTypeCInstantiated)
        {
            Instantiate(VehicleTypeC1);
            Instantiate(VehicleTypeC2);
            isVehicleTypeCInstantiated = true;
        }

                if (fourthTimer < 0 && !isVehicleTypeDInstantiated)
        {
            Instantiate(VehicleTypeD1);
            Instantiate(VehicleTypeD2);
            isVehicleTypeDInstantiated = true;
        }
    }
}
