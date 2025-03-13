using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationAvecDelai : MonoBehaviour
{
    [SerializeField ] private GameObject _objetACreer;
    [SerializeField] private GameObject _objetPlacemenent;

    void Start()
    {
        // execute la methode CreerObjet apres un delai de 5s
        //Invoke("CreerObjet", 5f);
        // execute la methode CreerObjet apres un delai initiale de 3s et e chaque 1s apres
        InvokeRepeating("CreerObjet", 3f, 1f);
        // Cancelle tous les Invoke() actifs
        //CancelInvoke();

    }

    
    public void ArreterMonnaie()
    {
        CancelInvoke();
    }

    void CreerObjet()
    {
        // Instancie un nouveau objet et garde une reference à lui
        GameObject nouvelleCopie = Instantiate(_objetACreer, _objetPlacemenent.transform.position, _objetPlacemenent.transform.rotation);

        // Prends une reference a le Rigidbody attache au nouveau objet
        Rigidbody _rbNouvelleCopie = nouvelleCopie.GetComponent<Rigidbody>();

        // Applique une force de translation initiale aleatoire
        _rbNouvelleCopie.AddRelativeForce(0, 2f + Random.value, 0, ForceMode.Impulse);

        // Applique une force de rotation initiale aleatoire
        _rbNouvelleCopie.AddRelativeTorque(0f, Random.value, Random.value, ForceMode.Impulse);
    }
}
