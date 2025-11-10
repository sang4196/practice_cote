# [카카오 인턴] 키패드 누르기
# https://school.programmers.co.kr/learn/courses/30/lessons/67256

def solution(numbers, hand):
    answer = ''

    keypad = [
        ["1", "2", "3"],
        ["4", "5", "6"],
        ["7", "8", "9"],
        ["*", "0", "#"]
    ]
    pos = {key: (row, col) for row, line in enumerate(keypad) for col, key in enumerate(line)}
    l = "*"
    r = "#"

    for num in map(str, numbers):
        if num in ["1","4","7"]:
            add = "L"
        elif num in ["3","6","9"]:
            add = "R"
        else:
            push_pos = pos[num]
            l_pos = pos[l]
            r_pos = pos[r]

            l_abs = abs(push_pos[0] - l_pos[0]) + abs(push_pos[1] - l_pos[1])
            r_abs = abs(push_pos[0] - r_pos[0]) + abs(push_pos[1] - r_pos[1])

            if l_abs > r_abs:
                add = "R"
            elif l_abs < r_abs:
                add = "L"
            else:
                if hand:
                    add = "R"
                else:
                    add = "L"
        answer += add
        if add == "R":
            r = num
        else:
            l = num

    return answer

if __name__ == '__main__':

    numbers = [
        [1, 3, 4, 5, 8, 2, 1, 4, 5, 9, 5],
        [7, 0, 8, 2, 8, 3, 1, 5, 7, 6, 2],
        [1, 2, 3, 4, 5, 6, 7, 8, 9, 0]
    ]
    hand = [True, False, True]
    result = [
        "LRLLLRLLRRL",
        "LRLLRRLLLRR",
        "LLRLLRLLRL"
    ]
    for i in range(len(result)):
        if result[i] == solution(numbers[i], hand[i]):
            print(True)
        else:
            print(False)