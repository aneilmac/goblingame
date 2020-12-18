using UnityEngine;
using System.Collections;

public class GoblinRun: MonoBehaviour {
  enum State {
    Running,
    Flying,
    Falling
  }

  public float wanderRadius = 25;

  private UnityEngine.AI.NavMeshAgent agent;

  private float timer;

  private Animator anim;

  private State state;

  private float current_y;

  void Start() {
    agent = GetComponent < UnityEngine.AI.NavMeshAgent > ();
    agent.destination = RandomGoal(transform.position, wanderRadius, -1);

    anim = GetComponent < Animator > ();
    state = State.Running;
    current_y = transform.position.y;
  }

  void Update() {
    if (state == State.Flying) {
      transform.position += new Vector3(0, 0.2f, 0);

      if (transform.position.y - current_y > 15) {
        transform.position = new Vector3(16, 20, 2);
        state = State.Falling;
      }
    }
    else if (state == State.Falling) {
      transform.position -= new Vector3(0, 0.2f, 0);
      if (transform.position.y - current_y < 10) {
             
             
        var audio_sources = GameObject.FindGameObjectsWithTag("Audio");

        foreach (GameObject audio in audio_sources)
        {
          var audio_source = audio.GetComponent<AudioSource>();
            audio_source.Play();
        }
        Destroy(gameObject);
      }
    }
    else if (GetComponent < Collider > ().bounds.Contains(agent.destination)) {
      agent.destination = RandomGoal(transform.position, wanderRadius, -1);
    }
  }

  void OnMouseDown() {
    state = State.Flying;
    Destroy(agent);
    int n = Random.Range(0, 2);
    if (n == 0) {
      anim.SetInteger("death", 1);
    } else {
      anim.SetInteger("death", 2);
    }
  }

  public Vector3 RandomGoal(Vector3 origin, float dist, int layermask) {
    Vector2 randDirection2D = Random.insideUnitCircle * dist;
    Vector3 randDirection = new Vector3(randDirection2D.x, 0, randDirection2D.y);

    randDirection += new Vector3(9, origin.y, -6);

    UnityEngine.AI.NavMeshHit navHit;

    UnityEngine.AI.NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

    return transform.TransformPoint(navHit.position);
  }
}