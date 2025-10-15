# PCCE 9번 이웃한 칸
# https://school.programmers.co.kr/learn/courses/30/lessons/250125

def solution(board, h, w):
    answer = 0

    color = board[h][w]
    if h > 0:
        if board[h-1][w] == color:
            answer += 1
    if w > 0:
        if board[h][w-1] == color:
            answer += 1
    if h < len(board) - 1:
        if board[h+1][w] == color:
            answer += 1
    if w < len(board[0]) - 1:
        if board[h][w+1] == color:
            answer += 1

    return answer

if __name__ == '__main__':
    board = [
        [["blue", "red", "orange", "red"], ["red", "red", "blue", "orange"],
         ["blue", "orange", "red", "red"], ["orange", "orange", "red", "blue"]],
        [["yellow", "green", "blue"], ["blue", "green", "yellow"], ["yellow", "blue", "blue"]]
    ]
    h = [1, 0]
    w = [1, 1]
    result = [2, 1]

    for i in range(len(board)):
        if result[i] == solution(board[i], h[i], w[i]):
            print(True)
        else:
            print(False)