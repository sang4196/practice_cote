# 실패율
# https://school.programmers.co.kr/learn/courses/30/lessons/42889?language=python3

def solution(N, stages):
    remain = len(stages)
    fail = {}

    for current_stage in range(1, N+1):
        if remain != 0:
            count = stages.count(current_stage)
            fail[current_stage] = count / remain
            remain -= count
        else:
            fail[current_stage] = 0

    result = sorted(fail.items(), key=lambda x: (-x[1], x[0]))
    return [stage for stage, _ in result]


if __name__ == '__main__':

    N = [5, 4]
    stages = [
        [2, 1, 2, 6, 2, 4, 3, 3],
        [4, 4, 4, 4, 4]
    ]
    result = [
        [3, 4, 2, 1, 5],
        [4, 1, 2, 3]
    ]

    for i in range(len(result)):
        if result[i] == solution(N[i], stages[i]):
            print(True)
        else:
            print(False)
