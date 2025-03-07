export function handleMainRoute(resp, user, interfaces) {
    resp.write("Main page");
    resp.write(user.username + '\n');
    const localhost = interfaces['Loopback Pseudo-Interface 1'];
    resp.write(localhost[1].address + '\n');
    resp.write(localhost[1].family + '\n');
    resp.end();
}
