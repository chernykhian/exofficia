void Update()
{
    // Move our position a step closer to the target.
    var step = speed * Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

    // Check if the position of the cube and sphere are approximately equal.
    if (Vector3.Distance(transform.position, target.position) < 0.001f)
    {
        // Swap the position of the cylinder.
        target.position *= -1.0f;
    }
}
