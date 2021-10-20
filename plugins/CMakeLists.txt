cmake_minimum_required(VERSION 3.18)

set(PROJECT_ROOT ${CMAKE_CURRENT_SOURCE_DIR})

set(CMAKE_CONFIGURATION_TYPES "Debug" "Release")

set(PROJECT_NAME Plugins)
project(${PROJECT_NAME})

set(PROJECT_VERSION_MAJOR 0)
set(PROJECT_VERSION_MINOR 1)
set(PROJECT_VERSION_PATCH 0)
set(PROJECT_VERSION ${PROJECT_VERSION_MAJOR}.${PROJECT_VERSION_MINOR}.${PROJECT_VERSION_PATCH})

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

function(expand_files FILES SOURCE)
    file (GLOB SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} ${SOURCE})
    set(${FILES} ${SOURCES} PARENT_SCOPE)
endfunction(expand_files)

function(expand_absolute_files FILES SOURCE)
    file (GLOB SOURCES ${SOURCE})
    set(${FILES} ${SOURCES} PARENT_SCOPE)
endfunction(expand_absolute_files)

set(OUTPUT_DIRECTORY "${CMAKE_CURRENT_SOURCE_DIR}/bin")
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY_DEBUG "${OUTPUT_DIRECTORY}")
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY_RELEASE "${OUTPUT_DIRECTORY}")

set(INSTALL_DIRECTORY "${CMAKE_CURRENT_SOURCE_DIR}/../Assets/Plugins")

if(MSVC)

    set(DEFAULT_CXX_FLAGS "/DWIN32 /D_WINDOWS /D_UNICODE /DUNICODE /W4 /WX- /nologo /fp:precise /arch:AVX /Zc:wchar_t /TP /Gd")

    if("1800" VERSION_LESS MSVC_VERSION)
        set(DEFAULT_CXX_FLAGS "${DEFAULT_CXX_FLAGS}")
    endif()
    if(MSVC_VERSION VERSION_LESS_EQUAL "1900")
        set(DEFAULT_CXX_FLAGS "${DEFAULT_CXX_FLAGS} /std:c++latest")
    else()
        set(DEFAULT_CXX_FLAGS "${DEFAULT_CXX_FLAGS} /std:c++17")
    endif()

    set(CMAKE_CXX_FLAGS "${DEFAULT_CXX_FLAGS}")
    set(CMAKE_CXX_FLAGS_DEBUG "/D_DEBUG /MDd /Zi /Ob0 /Od /RTC1 /Gy /GR- /GS /Gm-")
    set(CMAKE_CXX_FLAGS_RELEASE "/MD /O2 /GL /GR- /DNDEBUG")

elseif(UNIX)
    set(DEFAULT_CXX_FLAGS "-Wall -O2 -std=c++11 -march=skylake -fno-exception")
elseif(APPLE)
endif()

add_subdirectory(plugin00)
add_subdirectory(plugin01)
add_subdirectory(unit_tests)
