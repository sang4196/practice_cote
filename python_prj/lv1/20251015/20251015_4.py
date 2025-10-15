# 달리기 경주
# https://school.programmers.co.kr/learn/courses/30/lessons/178871

# list index로 조회시 전체를 돔.O(n)
# dict 이용시 hash를 이용해 한번에 찾음

def solution(players, callings):

    player_map = {
        name:idx
        for idx, name in enumerate(players)
    }

    for calling in callings:
        rank = player_map[calling]
        front = players[rank - 1]

        players[rank - 1], players[rank] = players[rank], players[rank - 1]

        player_map[front] += 1
        player_map[calling] -= 1

    return players

if __name__ == '__main__':

    players = ["mumu", "soe", "poe", "kai", "mine"]
    callings = ["kai", "kai", "mine", "mine"]
    result = ["mumu", "kai", "mine", "soe", "poe"]

    if result == solution(players, callings):
        print(True)
    else:
        print(False)