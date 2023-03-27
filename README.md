# OPQuiz
PoolC Unity Optimization 세미나 퀴즈

## 프로그램 설명
### 프로그램 동작 설명
1. Space를 누르고 있으면, 큐브가 생성된다.
2. Enter를 누르고 있으면, 생성된 큐브가 사라진다.
3. Cube Spanwer의 Spawn Time마다 새로운 큐브가 생성된다.

### 스크립트 및 주요 파일 설명
Assets/Scenes/SampleScene.scene: 여러분들이 테스트를 진행할 scene
Assets/Scripts/CubeSpawner.cs: 큐브를 생성하는 script (사용자의 취향에 맞게 수정 가능)
Assets/Scripts/ObjectPool.cs: 오브젝트 풀을 구현할 script (사용하지 않고 별도의 스크립트 사용 가능)
Assets/Cube.prefab: 생성할 큐브 프리팹

## 해야 될 것
1. 큐브가 유니티의 Instantiate/Destory를 통해서 생성/해제되고 있는 것을 Object Pool을 통해서 생성/해제되도록 만들 것
2. 프로파일링을 통해서 실제로 퍼포먼스에 어떻게 영향을 주었는지 비교해볼 것
3. Object Pool을 만드는 것 외에 최적화할 요소 찾아서 고쳐볼 것
4. 본인이 어느 부분들을 고쳤는지 반드시 설명할 것 (서면이든 세미나 시간에 설명하든 문제 없지만, 빼먹지 말 것)

## 힌트
1. 기존에 설정 되어있던 모든 설정 및 스크립트들을 추가/수정해도 괜찮습니다. 단, 프로그램 동작 설명에 있는 내용만큼은 정상적으로 작동해야만 합니다.
1-1. Object Pool을 ObjectPool.cs 내에서 구현하는 것을 권장하지만, 꼭 그렇게 하지 않아도 됩니다.
2. 기존 코드에 일부러 퍼포먼스를 낮추는 코드가 있으니 찾아보는 것을 권장합니다.
3. 사소한 질문 및 코드 관련해서 질문하는 것 모두 환영합니다.
