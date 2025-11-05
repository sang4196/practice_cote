# [1차] 다트 게임
# https://school.programmers.co.kr/learn/courses/30/lessons/17682

import re

def solution(dartResult):
    calc = re.findall(r'(\d+)([SDT])([*#]?)', dartResult)
    scores = []

    for i, (num, bonus, option) in enumerate(calc):
        score = int(num)

        if bonus == "D":
            score = score ** 2
        elif bonus == "T":
            score = score**3

        if option == "*":
            score *= 2
            if i > 0:
                scores[i - 1] *= 2
        elif option == "#":
            score *= -1

        scores.append(score)

    return sum(scores)

if __name__ == '__main__':
    dartResult = [
        "1S2D*3T",
        "1D2S#10S",
        "1D2S0T",
        "1S*2T*3S",
        "1D#2S*3S",
        "1T2D3D#",
        "1D2S3T*"
    ]

    answer = [37, 9, 3, 23, 5, -4, 59]

    for i in range(len(answer)):
        if answer[i] == solution(dartResult[i]):
            print(True)
        else:
            print(False)