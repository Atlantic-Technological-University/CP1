plugins {
    application
}

group = "ie.atuDonegal"
version = "1.0-SNAPSHOT"

repositories {
    mavenCentral()
}

dependencies {
    testImplementation("org.junit.jupiter:junit-jupiter-api:5.8.1")
    testRuntimeOnly("org.junit.jupiter:junit-jupiter-engine:5.8.1")
}
application {
    mainClass = "edu.atudonegal.Gambler"
}


tasks.getByName<Test>("test") {
    useJUnitPlatform()
}