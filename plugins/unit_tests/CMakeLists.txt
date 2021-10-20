cmake_minimum_required(VERSION 3.18)

set(PROJECT_NAME unit_tests)
project(${PROJECT_NAME} LANGUAGES CSharp)

set(SOURCES "tests.cs" "${PROJECT_ROOT}/plugin00/Plugin00.cs" "${PROJECT_ROOT}/plugin01/Plugin01.cs")

add_executable(${PROJECT_NAME} ${SOURCES})

set_property(TARGET ${PROJECT_NAME} PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.6.2")
set_property(TARGET ${PROJECT_NAME} PROPERTY VS_PACKAGE_REFERENCES
    "MSTest.TestAdapter"
    "MSTest.TestFramework")

set_target_properties(${PROJECT_NAME} PROPERTIES
    VS_DEBUGGER_WORKING_DIRECTORY "${OUTPUT_DIRECTORY}")

add_dependencies(${PROJECT_NAME} plugin00)
add_dependencies(${PROJECT_NAME} plugin01)
