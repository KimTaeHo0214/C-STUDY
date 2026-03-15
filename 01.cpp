#include <iostream>
#include <string>

int main() {
    system("chcp 65001");
    std::cout << "안녕! C++!\n";

    // 변수: 컴퓨터가 정보를 기억하기 위해 사용하는 상자
    // 1. int: 정수형. 소수점이 없는 깔끔한 숫자를 담는다.
    // 2. double: 실수형. 소수점이 있는 정밀한 숫자를 담는다.
    // 3. std::string: 문자열. 단어나 문장을 담는다.
    
    int level;
    std::string Loman;

    level = 1972;
    Loman = "로만";

    std::cout << "내 이름은 " << Loman << "이라고 해!\n";

    return 0;
}
