using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoint;
    private int currenWaypointIndex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(waypoint[currenWaypointIndex].transform.position, transform.position) < .1f){
            currenWaypointIndex++;
            if (currenWaypointIndex >= waypoint.Length){
                currenWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoint[currenWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
