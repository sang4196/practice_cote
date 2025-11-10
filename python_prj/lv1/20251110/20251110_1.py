# 크레인 인형뽑기 게임
# https://school.programmers.co.kr/learn/courses/30/lessons/64061


def solution(board, moves):
    answer = 0

    # zip으로 열로 묶음. [(1,2), (3,4)] -> [(1,3),(2,4)]
    # stacks = list(zip(*board))  # 행렬 전치
    # 0은 제외니 0이상을 [::-1]역순으로 배치.
    # stacks = [list(filter(lambda x: x > 0, col))[::-1] for col in stacks]

    bucket = []
    stacks = {i: [] for i in range(1, len(board) + 1)}
    for f in reversed(board):
        for i, v in enumerate(f, start=1):
            if v > 0:
                stacks[i].append(v)

    for move in moves:
        if stacks[move]:
            value = stacks[move].pop()
            if bucket and bucket[-1] == value:
                answer += 2
                bucket.pop()
            else:
                bucket.append(value)

    return answer

if __name__ == '__main__':

    board = [
        [0,0,0,0,0],
        [0,0,1,0,3],
        [0,2,5,0,1],
        [4,2,4,4,2],
        [3,5,1,3,1]
    ]
    moves = [1,5,3,5,1,2,1,4]
    result = 4
    print(solution(board, moves) == result)