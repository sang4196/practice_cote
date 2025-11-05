# 완주하지 못한 선수
# https://school.programmers.co.kr/learn/courses/30/lessons/42576

def solution(participant, completion):
    participant.sort()
    completion.sort()

    for i in range(len(completion)):
        if participant[i] != completion[i]:
            return participant[i]
    return participant[-1]

# 출제의도
def solution2(participant, completion):
    dict = {}
    for p in participant:
        dict[p] = dict.get(p, 0) + 1
    for c in completion:
        dict[c] -= 1

    for k, v in dict.items():
        if v > 0:
            return k

if __name__ == '__main__':
    participant = [
        ["leo", "kiki", "eden"],
        ["marina", "josipa", "nikola", "vinko", "filipa"],
        ["mislav", "stanko", "mislav", "ana"]
    ]

    completion = [
        ["eden", "kiki"],
        ["josipa", "filipa", "marina", "nikola"],
        ["stanko", "ana", "mislav"]
    ]

    answer = ["leo", "vinko", "mislav"]

    for i in range(len(answer)):
        if answer[i] == solution(participant[i], completion[i]):
            print(True)
        else:
            print(False)