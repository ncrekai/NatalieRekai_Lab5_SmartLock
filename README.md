### NatalieRekai_Lab5
# Smart Lock Test

```mermaid
stateDiagram-init
    state if_state <<choice>>
    [*] --> InitialState
    InitialState --> if_state : EnterCode()
    if_state --> Unlocked : Correct
    if_state --> Locked : Incorrect
    InitialState --> Locked : Locked()
    InitialState --> Locked : Reset()
```