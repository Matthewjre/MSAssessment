using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obi;

[RequireComponent(typeof(ObiSolver))]
public class RemoveObiParticles : MonoBehaviour {


 	ObiSolver solver;

	 public ParticleSystem magicFire;
	 public Light fireLight;
	 public GameObject checkMark;


	private bool touchedKClO3;
	 private bool touchedSugar;

	void Awake(){
		solver = GetComponent<ObiSolver>();
	}

	void Start()
	{
		magicFire.Stop();
		fireLight.enabled = false;
	}

	void OnEnable () {
		solver.OnCollision += Solver_OnCollision;
	}

	void OnDisable(){
		solver.OnCollision -= Solver_OnCollision;
	}

	async void Solver_OnCollision (object sender, Obi.ObiSolver.ObiCollisionEventArgs e)
	{
		var world = ObiColliderWorld.GetInstance();

		// just iterate over all contacts in the current frame:
		foreach (Oni.Contact contact in e.contacts)
		{
			// if this one is an actual collision:
			if (contact.distance < 0.01)
			{
				ObiColliderBase col = world.colliderHandles[contact.bodyB].owner;
				if (col != null)
				{
					if(col.tag.ToString() == "KCIO3")
					{
						touchedKClO3 = true;
					}
					if(col.tag.ToString() == "Sugar")
					{
						touchedSugar = true;
					}
                    if(touchedKClO3 && touchedSugar)
					{
						checkMark.SetActive(true);
						magicFire.transform.position = col.transform.position;
						magicFire.Play();
						fireLight.enabled = true;
						Invoke("StopEmitter", 5);
					}
					else if (col.tag != "Glass")
                    {
                        int particleIndex = solver.simplices[contact.bodyA];
                        ObiSolver.ParticleInActor pa = solver.particleToActor[particleIndex];
                        (pa.actor as ObiEmitter).life[pa.indexInActor] = 0;
                    }
					StartCoroutine(resetDelay());
				}
			}
		}
	}

	private void StopEmitter() 
	{
		magicFire.Stop();
		fireLight.enabled = false;
	}

	IEnumerator resetDelay()
	{
		yield return new WaitForSeconds(1);
		touchedKClO3 = false;
		touchedSugar = false;
	}

}
