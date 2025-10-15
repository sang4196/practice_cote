# 추억 점수
# https://school.programmers.co.kr/learn/courses/30/lessons/176963

def solution(name, yearning, photo):
    answer = []

    score_map = {
        name[i]:yearning[i]
        for i in range(len(name))
    }

    for pepole in photo:
        score = 0
        for p in pepole:
            score += score_map.get(p, 0)
        answer.append(score)

    return answer

if __name__ == '__main__':
    name = [
        ["may", "kein", "kain", "radi"],
        ["kali", "mari", "don"],
        ["may", "kein", "kain", "radi"]
    ]
    yearning = [
        [5, 10, 1, 3],
        [11, 1, 55],
        [5, 10, 1, 3]
    ]
    photo = [
        [["may", "kein", "kain", "radi"], ["may", "kein", "brin", "deny"],
         ["kon", "kain", "may", "coni"]],
        [["kali", "mari", "don"], ["pony", "tom", "teddy"], ["con", "mona", "don"]],
        [["may"], ["kein", "deny", "may"], ["kon", "coni"]]
    ]
    result = [
        [19, 15, 6],
        [67, 0, 55],
        [5, 15, 0]
    ]

    for i in range(len(result)):
        if result[i] == solution(name[i], yearning[i], photo[i]):
            print(True)
        else:
            print(False)